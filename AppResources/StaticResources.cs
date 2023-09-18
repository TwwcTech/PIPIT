using System.Reflection;


namespace PIPIT.AppResources
{
    internal class StaticResources
    {
        public const string AppName = "PIPIT";
        public const string Version = "1.0";

        public static string DateTimeStamp
        {
            get { return DateTimeStamp; }
            private set { DateTimeStamp = DateTime.Now.ToString("ddMMyyyy"); }
        }

        public static string ShortcutPath
        {
            get { return ShortcutPath; }
            private set { ShortcutPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, $"{AppName}.lnk"); }
        }
    }
}
