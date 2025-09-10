using SDCloner.AppCore.Models;
using System.Management;

namespace SDCloner.AppCore.Services
{
    public class DriveService
    {
        public IEnumerable<RemovableDrive> GetRemovableDrives()
        {
            var drives = new List<RemovableDrive>();

            var searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_DiskDrive WHERE MediaType LIKE '%Removable%'"
            );

            foreach (ManagementObject disk in searcher.Get())
            {
                var partitions = disk.GetRelated("Win32_DiskPartition");
                foreach (ManagementObject partition in partitions)
                {
                    var logicalDisks = partition.GetRelated("Win32_LogicalDisk");
                    foreach (ManagementObject logicalDisk in logicalDisks)
                    {
                        drives.Add(new RemovableDrive
                        {
                            PhysicalPath = disk["DeviceID"]?.ToString() ?? "",
                            DeviceID = logicalDisk["DeviceID"]?.ToString() ?? "",
                            VolumeLabel = logicalDisk["VolumeName"]?.ToString() ?? "",
                            TotalSize = (long?)((ulong?)logicalDisk["Size"]) ?? 0
                        });
                    }
                }
            }

            return drives;
        }

        public bool isDriveCapacityEnough(RemovableDrive drive, ImageFile image)
        {
            return image.FileSize <= drive.TotalSize;
        }
    }

}
