using Microsoft.Win32;
using System.Reflection;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public static void RegisterApp(string appName, string appVersion)
        {

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
