using PIPIT.Backend;
using PIPIT.Backend.WinRegistry;
using PIPIT.Frontend;

namespace PIPIT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegiMan appRegistrator = new()
            {
                AppName = "PIPIT",
                RegistryAppPath = "Software"
            };

            if (!appRegistrator.IsAppRegistered())
            {
                appRegistrator.RegisterApp();
            }

            Shortcutter shortcutter = new();
            if (File.Exists(shortcutter.ShortcutPath))
            {
                Close();
            }
        }

        private void EnableStartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //// If checked is true add app to startup
            //if (EnableStartupCheckbox.Checked)
            //{
            //    // If shortcut does not exist
            //    if (!File.Exists(RegiMan.ShortcutPath))
            //    {
            //        // Create Shortcut
            //        Shortcutter.CreateShortcut();
            //    }
            //    // Add app to startup folder via registry
            //    RegiMan.AddToStartup();
            //}
            //else if (!EnableStartupCheckbox.Checked)
            //{
            //    if (RegiMan.IsStartupEnabled())
            //    {
            //        RegiMan.RemoveFromStartup();
            //    }
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form infoWindow = new InfoWindow();
            infoWindow.ShowDialog();
        }

        private void removeFromStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shortcutter shortcutter = new();
            shortcutter.DeleteShortcut();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Dispose(true);
            }
            else
            {
                e.Cancel = true;
                TrayIcon.Visible = true;
                //WindowState = FormWindowState.Minimized;
                Visible = false;
                Hide();
            }
        }
    }
}