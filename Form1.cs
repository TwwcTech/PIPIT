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

            PiptSummaryLabel.Text = "           Quickly fetch comprehensive public IP details with this tool utilizing ifconfig.co. " +
                "\r\n\r\n  - Public IP: Identify your network's public IP address." +
                "\r\n  - Country: Discover your country." +
                "\r\n  - Country ISO: View the ISO code for your country." +
                "\r\n  - Region Name: Identify your region by name." +
                "\r\n  - Region Code: Access the region code information." +
                "\r\n  - Zip Code: Know your postal code." +
                "\r\n  - City: Pinpoint your city of connection." +
                "\r\n  - Longitude: Get the precise longitude of your connection." +
                "\r\n  - Latitude: Discover the exact latitude of your connection." +
                "\r\n  - Time Zone: Determine your current time zone." +
                "\r\n  - ASN Organization: Autonomous System Number Organization associated with your IP." +
                "\r\n  - Hostname: Identify the hostname associated with your connection.";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Visible)
            {
                Hide();
            }

            Form infoWindow = new InfoWindow();
            infoWindow.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                TrayIcon.Visible = true;
                WindowState = FormWindowState.Minimized;
                Visible = false;
                Hide();
            }
        }

        private void showSummaryWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}