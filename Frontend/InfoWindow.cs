using PIPIT.Backend.PublicIP;
using PIPIT.Backend.PublicIP.PIPResources;

namespace PIPIT.Frontend
{
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private async void InfoWindow_Load(object sender, EventArgs e)
        {
            InfoWindowToolTip.SetToolTip(IPinfoPanel, "Displays the relative IP information");
            InfoWindowToolTip.SetToolTip(GeneralInfoPanel, "Displays general information");
            InfoWindowToolTip.SetToolTip(StartupCheckbox, "Enable app on startup");
            InfoWindowToolTip.SetToolTip(ExportButton, "Export information to a csv file");

            DateLabel.Text = $"Date : {DateTime.Now.ToString("ddMMyyyy")}";
            CurrentUserLabel.Text = $"Current User : {Environment.UserName}";
            MachineLabel.Text = Environment.MachineName;

            PIPSetters pipSetters = await RequestPIP.RequestJson();
            if (pipSetters != null)
            {
                IPLabel.Text = pipSetters.ip;
                CountryLabel.Text = pipSetters.country;
                ISOLabel.Text = pipSetters.country_iso;
                RegionLabel.Text = pipSetters.region_name;
                RegionCodeLabel.Text = pipSetters.region_code;
                ZipCodeLabel.Text = pipSetters.zip_code;
                CityLabel.Text = pipSetters.city;
                LatLabel.Text = $"{pipSetters.latitude}";
                LongLabel.Text = $"{pipSetters.longitude}";
                TimeZoneLabel.Text = pipSetters.time_zone;
                ASNOrgLabel.Text = pipSetters.asn_org;
                HostnameLabel.Text = pipSetters.hostname;
            }
        }

        private void StartupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Code goes here
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            // Code goes here
        }

        private void ZipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GeneralInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
