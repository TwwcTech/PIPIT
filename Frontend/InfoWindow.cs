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
            InfoWindowToolTip.SetToolTip(PIPInfoBox, "Displays the relative IP information");
            InfoWindowToolTip.SetToolTip(LocalInfoBox, "Displays general information");

            DateLabel.Text = $"Date : {DateTime.Today:ddMMyyyy}\nCurrent User : {Environment.UserName}\nMachine Name : {Environment.MachineName}";

            PIPSetters pipSetters = await RequestPIP.RequestJson();
            if (pipSetters != null)
            {
                IPLabel.Text = $"{pipSetters.ip}\n{pipSetters.country}\n{pipSetters.country_iso}\n{pipSetters.region_name}\n{pipSetters.region_code}\n{pipSetters.zip_code}\n" +
                    $"{pipSetters.city}\n{pipSetters.latitude}\n{pipSetters.longitude}\n{pipSetters.time_zone}\n{pipSetters.asn_org}\n{pipSetters.hostname}";
            }
        }

        private void ZipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GeneralInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}