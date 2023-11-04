using System.Reflection;

namespace PIPIT.Backend
{
    internal class Shortcutter
    {
        private string? _startupFolderPath;
        private string? _shortcutFileName;
        private string? _targetFilePath;
        private string? _shortcutPath;

        public string? StartupFolderPath
        {
            get => _startupFolderPath;
            private set => _startupFolderPath = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";
        }

        public string? ShortcutFileName
        {
            get => _shortcutFileName;
            private set => _shortcutFileName = "PIPIT.lnk";
        }

        public string? TargetFilePath
        {
            get => _targetFilePath;
            private set => _targetFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, ShortcutFileName!);
        }

        public string? ShortcutPath
        {
            get => _shortcutPath;
            private set => _shortcutPath = Path.Combine(StartupFolderPath!, ShortcutFileName!);
        }

        public void CreateShortcut()
        {
            using StreamWriter shortcutWriter = new(ShortcutPath!);
            try
            {
                shortcutWriter.WriteLine("[Desktop Entry]");
                shortcutWriter.WriteLine($"Version={1.0}");
                shortcutWriter.WriteLine($"Name={Path.GetFileNameWithoutExtension(ShortcutFileName)}");
                shortcutWriter.WriteLine($"Exec={TargetFilePath}");
                shortcutWriter.WriteLine("Terminal=false");
                shortcutWriter.WriteLine("Type=Application");
                shortcutWriter.Flush();
            }
            catch (Exception ex) { ex.ToString(); }
        }
    }
}