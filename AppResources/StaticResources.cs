using System.Reflection;


namespace PIPIT.AppResources
{
    internal class StaticResources
    {
        public const string AppName = "PIPIT";
        public const string Version = "1.0";

        private static string _shortcutPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, $"{AppName}.lnk");
        public static string ShortcutPath
        {
            get { return _shortcutPath; }
        }
    }
}
