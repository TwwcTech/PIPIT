using Microsoft.Win32;
using System.Reflection;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public string? AppName { get; } = "PIPIT";
        public string? RegistryAppPath { get; set; }
        public string? RegistryStartupPath { get; set; }
        public static string? ShortcutPath { get; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "PIPIT.lnk");

        public void RegisterApp()
        {
            using RegistryKey regKey = Registry.CurrentUser.CreateSubKey($"{RegistryAppPath}\\{AppName}");
            try
            {
                regKey.SetValue("InitDate", DateTime.Now.ToString("ddMMyyyy"));
                regKey.SetValue("AppVersion", 1.0);
            }
            catch (Exception ex) { ex.ToString(); }
        }

        public bool IsAppRegistered()
        {
            using RegistryKey regStatusKey = Registry.CurrentUser.OpenSubKey($"Software\\{AppName}")!;
            return regStatusKey != null;
        }

        public void AddToStartup()
        {
            using RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true)!; // Use "SOFTWARE" if having errors
            if (regKey != null)
            {
                try
                {
                    if (File.Exists(ShortcutPath))
                    {
                        regKey.SetValue(AppName, ShortcutPath);
                    }
                }
                catch (Exception ex) { ex.ToString(); }
            }
        }

        public bool IsStartupEnabled()
        {
            using RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", false)!;
            if (regKey != null)
            {
                try
                {
                    if (regKey.GetValue(AppName) != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex) { ex.ToString(); }
            }
            return false;
        }

        public void RemoveFromStartup()
        {
            using RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true)!;
            if (regKey != null)
            {
                try
                {
                    regKey.DeleteSubKey(AppName!, false);
                }
                catch (Exception ex) { ex.ToString(); }
            }
        }
    }
}
