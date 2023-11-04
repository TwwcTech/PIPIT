using PIPIT.Backend.WinRegistry;
using System.Reflection;

namespace PIPIT.Backend
{
    internal class Shortcutter
    {
        public static void CreateShortcut()
        {
            using StreamWriter shortcutWriter = new(RegiMan.ShortcutPath!);
            try
            {
                shortcutWriter.WriteLine("[Desktop Entry]");
                shortcutWriter.WriteLine($"Version={1.0}");
                shortcutWriter.WriteLine($"Name={Path.GetFileNameWithoutExtension(RegiMan.ShortcutPath)}");
                shortcutWriter.WriteLine($"Exec={Assembly.GetExecutingAssembly().Location}");
                shortcutWriter.WriteLine("Terminal=false");
                shortcutWriter.WriteLine("Type=Application");
                shortcutWriter.Flush();
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}
