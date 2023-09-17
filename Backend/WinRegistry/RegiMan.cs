using Microsoft.Win32;
using System.Reflection;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public static void RegisterApp(string appName, string appVersion)
        {
            /* + Create a folder with the apps name and hold regkey values that 
             *   show when app was firt launched in "Software\\" folder
             *       - Regkey value: InitDate (DateTime) - Timestamp of when app was first launched
             *       - Regkey value: StartupEnabled (bool) - True or False if the tray app launches during startup (editable) */
        }

        public static void AddToStartup(string appName)
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true)!) // Use "SOFTWARE" if having errors
            {
                if (regKey != null)
                {
                    try
                    {
                        regKey.SetValue(appName, Assembly.GetExecutingAssembly().Location);
                    }
                    catch (Exception ex) { throw new Exception(ex.ToString()); }
                }
            }
        }
    }
}
