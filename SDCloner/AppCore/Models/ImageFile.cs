namespace SDCloner.AppCore.Models
{
    public class ImageFile
    {
        public string FilePath { get; set; } = string.Empty;
        public long FileSize { get; set; } = 0;

        public ImageFile(string path, long size)
        {
            FilePath = path;
            FileSize = size;
        }
    }
}
