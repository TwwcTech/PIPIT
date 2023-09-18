using PIPIT.Backend.WinRegistry;

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
            /* + Check if the app has ran before (registerd):
             *   - if not prompt the user with the setup window
             *   - if it has, check if the "IsStartupEnabled" option
             *     is "true" or "false":
             *     > true = skip the window and only start the trayicon app
             *     > false = open the options window on startup */
            bool registeredStatus = RegiMan.IsAppRegistered();
            if (registeredStatus)
            {
                bool isStartupEnabled = RegiMan.IsStartupEnabled();
                if (isStartupEnabled)
                {
                    Hide();
                    TrayIcon.Visible = true;
                }
                else
                {

                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog(this);
        }

        private void ifconfigcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ifconfig.co menu item
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit menu item
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            Hide();
        }
    }
}