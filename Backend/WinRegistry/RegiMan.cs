using Microsoft.Win32;
using PIPIT.AppResources;
using System.Reflection;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public static void RegisterApp(bool startupEnabled)
        {
            using (RegistryKey regKey = Registry.CurrentUser.CreateSubKey($"Software\\{StaticResources.AppName}"))
            {
                try
                {
                    regKey.SetValue("InitDate", StaticResources.DateTimeStamp);
                    regKey.SetValue("AppVersion", StaticResources.Version);
                    regKey.SetValue("StartupEnabled", startupEnabled.ToString());
                }
                catch (Exception ex) { ex.ToString(); }
            }
        }


        public static bool ParseStartupValue()
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false)!)
            {
                if (regKey != null)
                {
                    try
                    {
                        return (bool)regKey.GetValue(StaticResources.AppName)!;
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
            }
            return false;
        }
        public static void AddToStartup()
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true)!) // Use "SOFTWARE" if having errors
            {
                if (regKey != null)
                {
                    try
                    {
                        if (File.Exists(StaticResources.ShortcutPath))
                        {
                            regKey.SetValue(StaticResources.AppName, StaticResources.ShortcutPath);
                        }
                        return;
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
            }
        }

        public static void RemoveFromStartup()
        {
            using (RegistryKey regKey = Registry.CurrentUser.)
        }
    }
}
