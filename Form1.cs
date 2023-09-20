using PIPIT.AppResources;
using PIPIT.Backend;
using PIPIT.Backend.WinRegistry;
using System.Diagnostics;

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
            // If this is not a new device
            if (RegiMan.IsAppRegistered())
            {
                // If startup is enabled
                if (RegiMan.IsStartupEnabled())
                {
                    // Start the tray icon and close the main window
                    TrayIcon.Visible = true;
                    Close();
                }
                // Only start the tray icon
                TrayIcon.Visible = true;
            }
            // If this is a new device
            else
            {
                // Warning box showing on first time run
                DialogResult dialogResult = MessageBox.Show("New device detected, continue?", "New Device Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        //RegiMan.RegisterApp();
                        TrayIcon.Visible = true;
                        break;
                    case DialogResult.No:
                        Dispose();
                        break;
                }
            }
        }

        private void EnableStartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // If checked is true add app to startup
            if (EnableStartupCheckbox.Checked)
            {
                // Checks if shortcut exists
                if (!File.Exists(StaticResources.ShortcutPath))
                {
                    // Create Shortcut
                    Shortcutter.CreateShortcut();
                }
                // Add app to startup folder via registry
                RegiMan.AddToStartup();
            }
            // If checked is false remove it from startup
            else
            {
                // Checks to see if app is in startup folder
                if (RegiMan.IsStartupEnabled())
                {
                    // Remove app from startup folder via registry
                    RegiMan.RemoveFromStartup();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the app entirely
            Dispose(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Minimizes app and hides all controls when closing app
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            Visible = false;
            Hide();
        }
    }
}