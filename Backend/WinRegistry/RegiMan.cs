using Microsoft.Win32;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public string? AppName { get; } = "PIPIT";
        public string? RegistryAppPath { get; set; }

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
    }
}
