using Microsoft.Win32;
using System.Reflection;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public static void RegisterApp(string appName, string appVersion)
        {
            /* + Create a folder with the apps name and hold regkey values
             *   that show when app was firt launched.
             *       - Regkey value: InitDate (DateTime) - Timestamp of when app was first launched
             *       - Regkey value: StartupEnabled (bool) - True or False if the tray app launches during startup (editable) */ 
        }

        public static void AddToStartup(string appName)
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)!)
            {
                if (regKey != null)
                {
                    try
                    {
                        string targetExe = Assembly.GetExecutingAssembly().Location;
                        regKey.SetValue(appName, targetExe);
                    }
                    catch (Exception ex) { throw new Exception(ex.ToString()); }
                }
            }
        }
    }
}
