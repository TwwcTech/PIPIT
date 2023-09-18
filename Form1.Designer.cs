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
            optionsToolStripMenuItem = new ToolStripMenuItem();
            ifconfigcoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
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
            TrayIconMenu.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, ifconfigcoToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            TrayIconMenu.Name = "TrayIconMenu";
            TrayIconMenu.Size = new Size(241, 139);
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(240, 32);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // ifconfigcoToolStripMenuItem
            // 
            ifconfigcoToolStripMenuItem.Name = "ifconfigcoToolStripMenuItem";
            ifconfigcoToolStripMenuItem.Size = new Size(240, 32);
            ifconfigcoToolStripMenuItem.Text = "ifconfig.co";
            ifconfigcoToolStripMenuItem.Click += ifconfigcoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(240, 32);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem ifconfigcoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}