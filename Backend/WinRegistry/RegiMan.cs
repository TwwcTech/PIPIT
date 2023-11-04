using Microsoft.Win32;

namespace PIPIT.Backend.WinRegistry
{
    internal class RegiMan
    {
        public string? AppName { get; set; } 
        public string? RegistryAppPath { get; set; }

        public void RegisterApp()
        {
            using RegistryKey regKey = Registry.CurrentUser.CreateSubKey($"{RegistryAppPath}\\{AppName}");
            try
            {
                regKey.SetValue("InitDate", DateTime.Today.ToString("ddMMyyyy"));
                regKey.SetValue("AppVersion", 1.0);
            }
            catch (Exception ex) { ex.ToString(); }
        }

        public bool IsAppRegistered()
        {
            using RegistryKey regStatusKey = Registry.CurrentUser.OpenSubKey($"{RegistryAppPath}\\{AppName}")!;
            return regStatusKey != null;
        }
    }
}