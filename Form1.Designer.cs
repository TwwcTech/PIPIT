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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TrayIcon = new NotifyIcon(components);
            TrayIconMenu = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            showSummaryWindowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ExitButton = new Button();
            PiptSummaryLabel = new Label();
            summaryLabelPanel = new Panel();
            pipitControlsPanel = new Panel();
            TrayIconMenu.SuspendLayout();
            summaryLabelPanel.SuspendLayout();
            pipitControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TrayIcon
            // 
            TrayIcon.ContextMenuStrip = TrayIconMenu;
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "PIPIT";
            TrayIcon.Visible = true;
            // 
            // TrayIconMenu
            // 
            TrayIconMenu.ImageScalingSize = new Size(24, 24);
            TrayIconMenu.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, showSummaryWindowToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            TrayIconMenu.Name = "TrayIconMenu";
            TrayIconMenu.Size = new Size(205, 76);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(204, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // showSummaryWindowToolStripMenuItem
            // 
            showSummaryWindowToolStripMenuItem.Name = "showSummaryWindowToolStripMenuItem";
            showSummaryWindowToolStripMenuItem.Size = new Size(204, 22);
            showSummaryWindowToolStripMenuItem.Text = "Show Summary Window";
            showSummaryWindowToolStripMenuItem.Click += showSummaryWindowToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(201, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(204, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(318, 14);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 34);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PiptSummaryLabel
            // 
            PiptSummaryLabel.AutoSize = true;
            PiptSummaryLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PiptSummaryLabel.Location = new Point(12, 9);
            PiptSummaryLabel.Name = "PiptSummaryLabel";
            PiptSummaryLabel.Size = new Size(57, 21);
            PiptSummaryLabel.TabIndex = 3;
            PiptSummaryLabel.Text = "label1";
            // 
            // summaryLabelPanel
            // 
            summaryLabelPanel.Controls.Add(PiptSummaryLabel);
            summaryLabelPanel.Dock = DockStyle.Fill;
            summaryLabelPanel.Location = new Point(0, 0);
            summaryLabelPanel.Name = "summaryLabelPanel";
            summaryLabelPanel.Size = new Size(717, 453);
            summaryLabelPanel.TabIndex = 4;
            // 
            // pipitControlsPanel
            // 
            pipitControlsPanel.Controls.Add(ExitButton);
            pipitControlsPanel.Dock = DockStyle.Bottom;
            pipitControlsPanel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pipitControlsPanel.Location = new Point(0, 393);
            pipitControlsPanel.Name = "pipitControlsPanel";
            pipitControlsPanel.Size = new Size(717, 60);
            pipitControlsPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(717, 453);
            ControlBox = false;
            Controls.Add(pipitControlsPanel);
            Controls.Add(summaryLabelPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PIPIT";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            TrayIconMenu.ResumeLayout(false);
            summaryLabelPanel.ResumeLayout(false);
            summaryLabelPanel.PerformLayout();
            pipitControlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openToolStripMenuItem;
        private Button ExitButton;
        private Label PiptSummaryLabel;
        private ToolStripMenuItem showSummaryWindowToolStripMenuItem;
        private Panel summaryLabelPanel;
        private Panel pipitControlsPanel;
    }
}