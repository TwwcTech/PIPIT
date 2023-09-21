using PIPIT.AppResources;
using System.Reflection;

namespace PIPIT.Backend
{
    internal class Shortcutter
    {
        public static void CreateShortcut()
        {
            using (StreamWriter shortcutWriter = new StreamWriter(StaticResources.ShortcutPath))
            {
                try
                {
                    shortcutWriter.WriteLine("[Desktop Entry]");
                    shortcutWriter.WriteLine($"Version={StaticResources.Version}");
                    shortcutWriter.WriteLine($"Name={Path.GetFileNameWithoutExtension(StaticResources.ShortcutPath)}");
                    shortcutWriter.WriteLine($"Exec={Assembly.GetExecutingAssembly().Location}");
                    shortcutWriter.WriteLine("Terminal=false");
                    shortcutWriter.WriteLine("Type=Application");
                    shortcutWriter.Flush();
                }
                catch (Exception ex) { ex.ToString(); }
            }
        }
    }
}
