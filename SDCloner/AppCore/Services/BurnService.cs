using SDCloner.AppCore.Models;
using System.Diagnostics;

namespace SDCloner.AppCore.Services
{
    public class BurnService
    {
        public async Task BurnAsync(RemovableDrive drive, ImageFile image, IProgress<BurnProgress> progress)
        {
            if (!File.Exists(image.FilePath))
                throw new FileNotFoundException("Archivo IMG no encontrado.", image.FilePath);

            string driveNumberStr = drive.PhysicalPath.Replace(@"\\.\PHYSICALDRIVE", string.Empty);
            if (!int.TryParse(driveNumberStr, out int diskNumber))
                throw new InvalidOperationException("No se pudo obtener el número del disco desde PhysicalPath.");

            string psScript = $@"
                Set-Disk -Number {diskNumber} -IsReadOnly $false
                $partitions = Get-Partition -DiskNumber {diskNumber}
                foreach ($p in $partitions) {{
                    Remove-Partition -DiskNumber {diskNumber} -PartitionNumber $p.PartitionNumber -Confirm:$false
                }}
                $fileStream = [System.IO.File]::OpenRead(""{image.FilePath}"")
                $driveStream = New-Object System.IO.FileStream(""\\.\PHYSICALDRIVE{diskNumber}"", [System.IO.FileMode]::Open, [System.IO.FileAccess]::ReadWrite)
                $buffer = New-Object byte[] (1MB)
                $totalBytes = $fileStream.Length
                $written = 0
                $stopwatch = [System.Diagnostics.Stopwatch]::StartNew()
                while (($read = $fileStream.Read($buffer, 0, $buffer.Length)) -gt 0) {{
                    $driveStream.Write($buffer, 0, $read)
                    $written += $read
                    $percent = [math]::Round(($written / $totalBytes) * 100)
                    $elapsed = $stopwatch.Elapsed.TotalSeconds
                    $remaining = [math]::Round(($totalBytes - $written) / ($written / $elapsed))
                    Write-Output ""PROGRESS:$percent,REMAIN:$remaining""
                }}
                $fileStream.Close()
                $driveStream.Close()
                ";

            var psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command -",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(psi))
            {
                if (process == null)
                    throw new InvalidOperationException("No se pudo iniciar PowerShell");
                process.StandardInput.WriteLine(psScript);
                process.StandardInput.Close();

                string? line;
                while ((line = await process.StandardOutput.ReadLineAsync()) != null)
                {
                    if (line.StartsWith("PROGRESS:"))
                    {
                        var parts = line.Replace("PROGRESS:", "").Split(',');
                        if (parts.Length == 2 &&
                            byte.TryParse(parts[0], out byte percent) &&
                            ushort.TryParse(parts[1].Replace("REMAIN:", ""), out ushort remain))
                        {
                            progress.Report(new BurnProgress
                            {
                                Percent = percent,
                                RemainingTime = remain
                            });
                        }
                    }
                }

                await process.WaitForExitAsync();
            }
        }
    }
}
