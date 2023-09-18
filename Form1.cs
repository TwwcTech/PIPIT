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
            if (RegiMan.IsAppRegistered())
            {
                if (RegiMan.IsStartupEnabled())
                {
                    TrayIcon.Visible = true;
                    Close();
                }
                TrayIcon.Visible = true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("New device detected, you will need to configure app settings.\nPress 'Yes' to Continue or 'No' to exit.", "New Device Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        RegiMan.RegisterApp();
                        break;
                    case DialogResult.No:
                        Dispose();
                        break;
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog(this);
            if (RegiMan.IsStartupEnabled())
            {
                // Code to make the "Enable on Startup" check box is true
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
            Hide();
        }
    }
}