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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWindow));
            IPLabel = new Label();
            DateLabel = new Label();
            InfoWindowToolTip = new ToolTip(components);
            PIPInfoBox = new GroupBox();
            LocalInfoBox = new GroupBox();
            PIPInfoBox.SuspendLayout();
            LocalInfoBox.SuspendLayout();
            SuspendLayout();
            // 
            // IPLabel
            // 
            IPLabel.AutoSize = true;
            IPLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IPLabel.Location = new Point(6, 49);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new Size(169, 19);
            IPLabel.TabIndex = 0;
            IPLabel.Text = "Public IP Information label";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(22, 47);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(152, 19);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "Local Information Label";
            // 
            // PIPInfoBox
            // 
            PIPInfoBox.Controls.Add(IPLabel);
            PIPInfoBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PIPInfoBox.Location = new Point(12, 12);
            PIPInfoBox.Name = "PIPInfoBox";
            PIPInfoBox.Size = new Size(625, 419);
            PIPInfoBox.TabIndex = 3;
            PIPInfoBox.TabStop = false;
            PIPInfoBox.Text = "Public IP Information";
            // 
            // LocalInfoBox
            // 
            LocalInfoBox.Controls.Add(DateLabel);
            LocalInfoBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LocalInfoBox.Location = new Point(227, 437);
            LocalInfoBox.Name = "LocalInfoBox";
            LocalInfoBox.Size = new Size(200, 100);
            LocalInfoBox.TabIndex = 4;
            LocalInfoBox.TabStop = false;
            LocalInfoBox.Text = "Local Information";
            // 
            // InfoWindow
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(649, 559);
            Controls.Add(LocalInfoBox);
            Controls.Add(PIPInfoBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IP Information";
            Load += InfoWindow_Load;
            PIPInfoBox.ResumeLayout(false);
            PIPInfoBox.PerformLayout();
            LocalInfoBox.ResumeLayout(false);
            LocalInfoBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label IPLabel;
        private Label DateLabel;
        private ToolTip InfoWindowToolTip;
        private GroupBox PIPInfoBox;
        private GroupBox LocalInfoBox;
    }
}