namespace PIPIT.Frontend
{
    partial class InfoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWindow));
            IPinfoPanel = new Panel();
            OptionsPanel = new Panel();
            GeneralInfoPanel = new Panel();
            IPLabel = new Label();
            CountryLabel = new Label();
            ISOLabel = new Label();
            RegionLabel = new Label();
            RegionCodeLabel = new Label();
            ZipCodeLabel = new Label();
            CityLabel = new Label();
            LatLabel = new Label();
            LongLabel = new Label();
            TimeZoneLabel = new Label();
            ASNOrgLabel = new Label();
            HostnameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            IPinfoPanel.SuspendLayout();
            GeneralInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IPinfoPanel
            // 
            IPinfoPanel.Controls.Add(HostnameLabel);
            IPinfoPanel.Controls.Add(ASNOrgLabel);
            IPinfoPanel.Controls.Add(TimeZoneLabel);
            IPinfoPanel.Controls.Add(LongLabel);
            IPinfoPanel.Controls.Add(LatLabel);
            IPinfoPanel.Controls.Add(CityLabel);
            IPinfoPanel.Controls.Add(ZipCodeLabel);
            IPinfoPanel.Controls.Add(RegionCodeLabel);
            IPinfoPanel.Controls.Add(RegionLabel);
            IPinfoPanel.Controls.Add(ISOLabel);
            IPinfoPanel.Controls.Add(CountryLabel);
            IPinfoPanel.Controls.Add(IPLabel);
            IPinfoPanel.Location = new Point(12, 12);
            IPinfoPanel.Name = "IPinfoPanel";
            IPinfoPanel.Size = new Size(375, 536);
            IPinfoPanel.TabIndex = 0;
            // 
            // OptionsPanel
            // 
            OptionsPanel.Location = new Point(393, 177);
            OptionsPanel.Name = "OptionsPanel";
            OptionsPanel.Size = new Size(244, 370);
            OptionsPanel.TabIndex = 1;
            // 
            // GeneralInfoPanel
            // 
            GeneralInfoPanel.Controls.Add(label2);
            GeneralInfoPanel.Controls.Add(label1);
            GeneralInfoPanel.Location = new Point(393, 12);
            GeneralInfoPanel.Name = "GeneralInfoPanel";
            GeneralInfoPanel.Size = new Size(244, 159);
            GeneralInfoPanel.TabIndex = 2;
            // 
            // IPLabel
            // 
            IPLabel.AutoSize = true;
            IPLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IPLabel.Location = new Point(14, 16);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new Size(0, 25);
            IPLabel.TabIndex = 0;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(14, 61);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(84, 25);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country :";
            // 
            // ISOLabel
            // 
            ISOLabel.AutoSize = true;
            ISOLabel.Location = new Point(14, 102);
            ISOLabel.Name = "ISOLabel";
            ISOLabel.Size = new Size(50, 25);
            ISOLabel.TabIndex = 2;
            ISOLabel.Text = "ISO :";
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Location = new Point(14, 143);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(76, 25);
            RegionLabel.TabIndex = 3;
            RegionLabel.Text = "Region :";
            // 
            // RegionCodeLabel
            // 
            RegionCodeLabel.AutoSize = true;
            RegionCodeLabel.Location = new Point(14, 185);
            RegionCodeLabel.Name = "RegionCodeLabel";
            RegionCodeLabel.Size = new Size(123, 25);
            RegionCodeLabel.TabIndex = 4;
            RegionCodeLabel.Text = "Region Code :";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(14, 228);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(93, 25);
            ZipCodeLabel.TabIndex = 5;
            ZipCodeLabel.Text = "Zip Code :";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(14, 268);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(51, 25);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City :";
            // 
            // LatLabel
            // 
            LatLabel.AutoSize = true;
            LatLabel.Location = new Point(14, 312);
            LatLabel.Name = "LatLabel";
            LatLabel.Size = new Size(84, 25);
            LatLabel.TabIndex = 7;
            LatLabel.Text = "Latitude :";
            // 
            // LongLabel
            // 
            LongLabel.AutoSize = true;
            LongLabel.Location = new Point(14, 359);
            LongLabel.Name = "LongLabel";
            LongLabel.Size = new Size(101, 25);
            LongLabel.TabIndex = 8;
            LongLabel.Text = "Longitude :";
            // 
            // TimeZoneLabel
            // 
            TimeZoneLabel.AutoSize = true;
            TimeZoneLabel.Location = new Point(14, 404);
            TimeZoneLabel.Name = "TimeZoneLabel";
            TimeZoneLabel.Size = new Size(104, 25);
            TimeZoneLabel.TabIndex = 9;
            TimeZoneLabel.Text = "Time Zone :";
            // 
            // ASNOrgLabel
            // 
            ASNOrgLabel.AutoSize = true;
            ASNOrgLabel.Location = new Point(14, 452);
            ASNOrgLabel.Name = "ASNOrgLabel";
            ASNOrgLabel.Size = new Size(92, 25);
            ASNOrgLabel.TabIndex = 10;
            ASNOrgLabel.Text = "ASN Org :";
            // 
            // HostnameLabel
            // 
            HostnameLabel.AutoSize = true;
            HostnameLabel.Location = new Point(14, 497);
            HostnameLabel.Name = "HostnameLabel";
            HostnameLabel.Size = new Size(103, 25);
            HostnameLabel.TabIndex = 11;
            HostnameLabel.Text = "Hostname :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 40);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 88);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // InfoWindow
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(649, 559);
            Controls.Add(GeneralInfoPanel);
            Controls.Add(OptionsPanel);
            Controls.Add(IPinfoPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IP Information";
            Load += InfoWindow_Load;
            IPinfoPanel.ResumeLayout(false);
            IPinfoPanel.PerformLayout();
            GeneralInfoPanel.ResumeLayout(false);
            GeneralInfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel IPinfoPanel;
        private Panel OptionsPanel;
        private Panel GeneralInfoPanel;
        private Label ZipCodeLabel;
        private Label RegionCodeLabel;
        private Label RegionLabel;
        private Label ISOLabel;
        private Label CountryLabel;
        private Label IPLabel;
        private Label ASNOrgLabel;
        private Label TimeZoneLabel;
        private Label LongLabel;
        private Label LatLabel;
        private Label CityLabel;
        private Label HostnameLabel;
        private Label label2;
        private Label label1;
    }
}