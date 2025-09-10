namespace SDCloner.AppCore.Models
{
    public class BurnProgress
    {
        public byte Percent { get; set; }
        public ushort RemainingTime { get; set; }

        public BurnProgress()
        {
            Percent = 0;
            RemainingTime = 0;
        }
    }
}
