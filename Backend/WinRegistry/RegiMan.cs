using Microsoft.Win32;
using PIPIT.AppResources;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public static void RegisterApp()
        {
            using (RegistryKey regKey = Registry.CurrentUser.CreateSubKey($"Software\\{StaticResources.AppName}"))
            {
                try
                {
                    regKey.SetValue("InitDate", StaticResources.DateTimeStamp);
                    regKey.SetValue("AppVersion", StaticResources.Version);
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
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
            }
        }

        public static void RemoveFromStartup()
        {
            using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true)!)
            {
                if (regKey != null)
                {
                    try
                    {
                        regKey.DeleteSubKey(StaticResources.AppName, false);
                    }
                    catch (Exception ex) { ex.ToString(); }
                }
            }
        }
    }
}
