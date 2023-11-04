using System.Reflection;

namespace PIPIT.Backend
{
    internal static class Shortcutter
    {
        public static void CreateShortcut()
        {
            string startupFolderPath = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";
            string shortcutFileName = "PIPIT.lnk";
            string targetFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, shortcutFileName);
            string shortcutPath = Path.Combine(startupFolderPath, shortcutFileName);

            using StreamWriter shortcutWriter = new(shortcutPath!);
            try
            {
                /* OLD */
                //shortcutWriter.WriteLine("[Desktop Entry]");
                //shortcutWriter.WriteLine($"Version={1.0}");
                //shortcutWriter.WriteLine($"Name={Path.GetFileNameWithoutExtension(shortcutPath)}");
                //shortcutWriter.WriteLine($"Exec={Assembly.GetExecutingAssembly().Location}");
                //shortcutWriter.WriteLine("Terminal=false");
                //shortcutWriter.WriteLine("Type=Application");
                //shortcutWriter.Flush();

                /* NEW */
                shortcutWriter.WriteLine("[Desktop Entry]");
                shortcutWriter.WriteLine($"Version={1.0}");
                shortcutWriter.WriteLine($"Name={Path.GetFileNameWithoutExtension(shortcutFileName)}");
                shortcutWriter.WriteLine($"Exec={targetFilePath}");
                shortcutWriter.WriteLine("Terminal=false");
                shortcutWriter.WriteLine("Type=Application");
                shortcutWriter.Flush();
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
