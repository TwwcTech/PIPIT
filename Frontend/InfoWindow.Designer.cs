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
            HostnameLabel = new Label();
            ASNOrgLabel = new Label();
            TimeZoneLabel = new Label();
            LongLabel = new Label();
            LatLabel = new Label();
            CityLabel = new Label();
            ZipCodeLabel = new Label();
            RegionCodeLabel = new Label();
            RegionLabel = new Label();
            ISOLabel = new Label();
            CountryLabel = new Label();
            IPLabel = new Label();
            OptionsPanel = new Panel();
            ExportButton = new Button();
            StartupCheckbox = new CheckBox();
            GeneralInfoPanel = new Panel();
            MachineLabel = new Label();
            CurrentUserLabel = new Label();
            DateLabel = new Label();
            IPinfoPanel.SuspendLayout();
            OptionsPanel.SuspendLayout();
            GeneralInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IPinfoPanel
            // 
            IPinfoPanel.BorderStyle = BorderStyle.FixedSingle;
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
            // HostnameLabel
            // 
            HostnameLabel.AutoSize = true;
            HostnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            HostnameLabel.Location = new Point(14, 497);
            HostnameLabel.Name = "HostnameLabel";
            HostnameLabel.Size = new Size(0, 28);
            HostnameLabel.TabIndex = 11;
            // 
            // ASNOrgLabel
            // 
            ASNOrgLabel.AutoSize = true;
            ASNOrgLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ASNOrgLabel.Location = new Point(14, 452);
            ASNOrgLabel.Name = "ASNOrgLabel";
            ASNOrgLabel.Size = new Size(0, 28);
            ASNOrgLabel.TabIndex = 10;
            // 
            // TimeZoneLabel
            // 
            TimeZoneLabel.AutoSize = true;
            TimeZoneLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TimeZoneLabel.Location = new Point(14, 404);
            TimeZoneLabel.Name = "TimeZoneLabel";
            TimeZoneLabel.Size = new Size(0, 28);
            TimeZoneLabel.TabIndex = 9;
            // 
            // LongLabel
            // 
            LongLabel.AutoSize = true;
            LongLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LongLabel.Location = new Point(14, 359);
            LongLabel.Name = "LongLabel";
            LongLabel.Size = new Size(17, 28);
            LongLabel.TabIndex = 8;
            LongLabel.Text = " ";
            // 
            // LatLabel
            // 
            LatLabel.AutoSize = true;
            LatLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LatLabel.Location = new Point(14, 312);
            LatLabel.Name = "LatLabel";
            LatLabel.Size = new Size(0, 28);
            LatLabel.TabIndex = 7;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CityLabel.Location = new Point(14, 268);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(0, 28);
            CityLabel.TabIndex = 6;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ZipCodeLabel.Location = new Point(14, 228);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(0, 28);
            ZipCodeLabel.TabIndex = 5;
            ZipCodeLabel.Click += ZipCodeLabel_Click;
            // 
            // RegionCodeLabel
            // 
            RegionCodeLabel.AutoSize = true;
            RegionCodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegionCodeLabel.Location = new Point(14, 185);
            RegionCodeLabel.Name = "RegionCodeLabel";
            RegionCodeLabel.Size = new Size(0, 28);
            RegionCodeLabel.TabIndex = 4;
            // 
            // RegionLabel
            // 
            RegionLabel.AutoSize = true;
            RegionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegionLabel.Location = new Point(14, 143);
            RegionLabel.Name = "RegionLabel";
            RegionLabel.Size = new Size(0, 28);
            RegionLabel.TabIndex = 3;
            // 
            // ISOLabel
            // 
            ISOLabel.AutoSize = true;
            ISOLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ISOLabel.Location = new Point(14, 102);
            ISOLabel.Name = "ISOLabel";
            ISOLabel.Size = new Size(0, 28);
            ISOLabel.TabIndex = 2;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CountryLabel.Location = new Point(14, 61);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(0, 28);
            CountryLabel.TabIndex = 1;
            // 
            // IPLabel
            // 
            IPLabel.AutoSize = true;
            IPLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IPLabel.Location = new Point(14, 16);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new Size(0, 28);
            IPLabel.TabIndex = 0;
            // 
            // OptionsPanel
            // 
            OptionsPanel.Controls.Add(ExportButton);
            OptionsPanel.Controls.Add(StartupCheckbox);
            OptionsPanel.Location = new Point(393, 177);
            OptionsPanel.Name = "OptionsPanel";
            OptionsPanel.Size = new Size(244, 371);
            OptionsPanel.TabIndex = 1;
            // 
            // ExportButton
            // 
            ExportButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ExportButton.Location = new Point(62, 195);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(112, 49);
            ExportButton.TabIndex = 2;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // StartupCheckbox
            // 
            StartupCheckbox.AutoSize = true;
            StartupCheckbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartupCheckbox.Location = new Point(38, 133);
            StartupCheckbox.Name = "StartupCheckbox";
            StartupCheckbox.Size = new Size(165, 32);
            StartupCheckbox.TabIndex = 1;
            StartupCheckbox.Text = "Enable Startup";
            StartupCheckbox.UseVisualStyleBackColor = true;
            StartupCheckbox.CheckedChanged += StartupCheckbox_CheckedChanged;
            // 
            // GeneralInfoPanel
            // 
            GeneralInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            GeneralInfoPanel.Controls.Add(MachineLabel);
            GeneralInfoPanel.Controls.Add(CurrentUserLabel);
            GeneralInfoPanel.Controls.Add(DateLabel);
            GeneralInfoPanel.Location = new Point(393, 12);
            GeneralInfoPanel.Name = "GeneralInfoPanel";
            GeneralInfoPanel.Size = new Size(244, 159);
            GeneralInfoPanel.TabIndex = 2;
            GeneralInfoPanel.Paint += GeneralInfoPanel_Paint;
            // 
            // MachineLabel
            // 
            MachineLabel.AutoSize = true;
            MachineLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MachineLabel.Location = new Point(15, 112);
            MachineLabel.Name = "MachineLabel";
            MachineLabel.Size = new Size(0, 28);
            MachineLabel.TabIndex = 2;
            // 
            // CurrentUserLabel
            // 
            CurrentUserLabel.AutoSize = true;
            CurrentUserLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentUserLabel.Location = new Point(15, 64);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(0, 28);
            CurrentUserLabel.TabIndex = 1;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(15, 19);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(0, 28);
            DateLabel.TabIndex = 0;
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
            OptionsPanel.ResumeLayout(false);
            OptionsPanel.PerformLayout();
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
        private Label CurrentUserLabel;
        private Label DateLabel;
        private CheckBox StartupCheckbox;
        private Label MachineLabel;
        private Button ExportButton;
    }
}