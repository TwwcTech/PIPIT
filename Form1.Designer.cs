namespace PIPIT
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TrayIcon = new NotifyIcon(components);
            TrayIconMenu = new ContextMenuStrip(components);
            opToolStripMenuItem = new ToolStripMenuItem();
            webToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            TrayIconMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.ContextMenuStrip = TrayIconMenu;
            TrayIcon.Text = "notifyIcon1";
            TrayIcon.Visible = true;
            // 
            // TrayIconMenu
            // 
            TrayIconMenu.ImageScalingSize = new Size(24, 24);
            TrayIconMenu.Items.AddRange(new ToolStripItem[] { opToolStripMenuItem, webToolStripMenuItem, toolStripSeparator1, helpToolStripMenuItem, aboutToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            TrayIconMenu.Name = "TrayIconMenu";
            TrayIconMenu.Size = new Size(241, 209);
            // 
            // opToolStripMenuItem
            // 
            opToolStripMenuItem.Name = "opToolStripMenuItem";
            opToolStripMenuItem.Size = new Size(240, 32);
            opToolStripMenuItem.Text = "Options";
            // 
            // webToolStripMenuItem
            // 
            webToolStripMenuItem.Name = "webToolStripMenuItem";
            webToolStripMenuItem.Size = new Size(240, 32);
            webToolStripMenuItem.Text = "ifconfig.co";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(237, 6);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(240, 32);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(240, 32);
            aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(240, 32);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Public IP Info Tool Setup";
            Load += MainForm_Load;
            TrayIconMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconMenu;
        private ToolStripMenuItem opToolStripMenuItem;
        private ToolStripMenuItem webToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}