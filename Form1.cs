using PIPIT.Backend;
using PIPIT.Backend.WinRegistry;
using System.Diagnostics;
using PIPIT.AppResources;

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
            // Checks if this is a new device
            if (RegiMan.IsAppRegistered())
            {
                // Checks if startup is enabled
                if (RegiMan.IsStartupEnabled())
                {
                    TrayIcon.Visible = true;
                    Close();
                }
                TrayIcon.Visible = true;
            }
            else
            {
                // Warning box showing on first time run, yes to continue and no to exit
                DialogResult dialogResult = MessageBox.Show("New device detected, continue", "New Device Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        // Enable when ready
                        //RegiMan.RegisterApp();
                        //TrayIcon.Visible = true;
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
                // If shortcut does not exist, create it
                if (!File.Exists(StaticResources.ShortcutPath))
                {
                    Shortcutter.CreateShortcut();
                }
                RegiMan.AddToStartup();
            }
            // If checked is false remove it from startup
            else
            {
                // Checks to see if app is in startup folder
                if (RegiMan.IsStartupEnabled())
                {
                    RegiMan.RemoveFromStartup();
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog(this);

            if (RegiMan.IsStartupEnabled())
            {
                EnableStartupCheckbox.Checked = true;
            }
        }

        private void ifconfigcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"https://ifconfig.co");
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            Visible = false;
            Hide();
        }
    }
}