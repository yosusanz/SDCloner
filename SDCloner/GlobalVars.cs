using System.Reflection;

namespace SDCloner
{
    public static class GlobalVars
    {
        public const string APP_NAME = "SDCloner";
        public static readonly Version? APP_VERSION = Assembly.GetExecutingAssembly().GetName().Version;
    }
}