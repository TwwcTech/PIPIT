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
            if (shortcutter.DoesShortcutExistInStartup())
            {
                Close();
            }
        }

        private void EnableStartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableStartupCheckbox.Checked)
            {
                Shortcutter createShortcutManager = new();
                if (!createShortcutManager.DoesShortcutExistInStartup())
                {
                    createShortcutManager.CreateShortcut();
                }
            }
            else if (!EnableStartupCheckbox.Checked)
            {
                Shortcutter deleteShortcutManager = new();
                if (deleteShortcutManager.DoesShortcutExistInStartup())
                {
                    deleteShortcutManager.DeleteShortcut();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form infoWindow = new InfoWindow();
            infoWindow.ShowDialog();
        }

        private void removeFromStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shortcutter shortcutter = new();
            if (shortcutter.DoesShortcutExistInStartup())
            {
                shortcutter.DeleteShortcut();
            }
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