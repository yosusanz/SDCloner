namespace SDCloner.AppCore.Models
{
    public class RemovableDrive
    {
        public string PhysicalPath { get; set; } = string.Empty;
        public string DeviceID { get; set; } = string.Empty;
        public string VolumeLabel { get; set; } = string.Empty;
        public long TotalSize { get; set; } = 0;
    }
}
