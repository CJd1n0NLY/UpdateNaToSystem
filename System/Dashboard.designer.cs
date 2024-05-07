
namespace System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timerSched = new System.Windows.Forms.Timer(this.components);
            this.timerOnGoing = new System.Windows.Forms.Timer(this.components);
            this.timerReq = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maintenanceTab = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.onGoingIcon = new System.Windows.Forms.PictureBox();
            this.requestIcon = new System.Windows.Forms.PictureBox();
            this.scheduledIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScheduledMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashboardMaintenance1 = new System.DashboardMaintenance();
            this.rooms_Admin_UC1 = new System.Rooms_Admin_UC();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onGoingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 10, 1, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1460, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 19);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1823, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 7, 30, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(97, 39);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(44, 10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 18);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // timerSched
            // 
            this.timerSched.Interval = 1;
            // 
            // timerOnGoing
            // 
            this.timerOnGoing.Interval = 1;
            // 
            // timerReq
            // 
            this.timerReq.Interval = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 147);
            this.panel1.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(109, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "ADMIN";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(287, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1495, 1030);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(103, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.maintenanceTab);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.onGoingIcon);
            this.panel2.Controls.Add(this.requestIcon);
            this.panel2.Controls.Add(this.scheduledIcon);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblScheduledMaintenance);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 927);
            this.panel2.TabIndex = 23;
            // 
            // maintenanceTab
            // 
            this.maintenanceTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.maintenanceTab.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.maintenanceTab.CheckedState.FillColor = System.Drawing.Color.Black;
            this.maintenanceTab.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceTab.CustomBorderColor = System.Drawing.Color.Transparent;
            this.maintenanceTab.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.maintenanceTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maintenanceTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maintenanceTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maintenanceTab.FillColor = System.Drawing.Color.Black;
            this.maintenanceTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maintenanceTab.ForeColor = System.Drawing.SystemColors.Control;
            this.maintenanceTab.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.maintenanceTab.Image = ((System.Drawing.Image)(resources.GetObject("maintenanceTab.Image")));
            this.maintenanceTab.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maintenanceTab.ImageOffset = new System.Drawing.Point(3, 0);
            this.maintenanceTab.ImageSize = new System.Drawing.Size(30, 30);
            this.maintenanceTab.Location = new System.Drawing.Point(0, 104);
            this.maintenanceTab.Name = "maintenanceTab";
            this.maintenanceTab.Size = new System.Drawing.Size(284, 50);
            this.maintenanceTab.TabIndex = 34;
            this.maintenanceTab.Text = "Maintenance";
            this.maintenanceTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maintenanceTab.TextOffset = new System.Drawing.Point(5, 0);
            this.maintenanceTab.Click += new System.EventHandler(this.maintenanceTab_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.Checked = true;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(0, 48);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(284, 50);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "Show Rooms";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // onGoingIcon
            // 
            this.onGoingIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("onGoingIcon.BackgroundImage")));
            this.onGoingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onGoingIcon.Location = new System.Drawing.Point(-2020, -949);
            this.onGoingIcon.Name = "onGoingIcon";
            this.onGoingIcon.Size = new System.Drawing.Size(30, 30);
            this.onGoingIcon.TabIndex = 15;
            this.onGoingIcon.TabStop = false;
            // 
            // requestIcon
            // 
            this.requestIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestIcon.BackgroundImage")));
            this.requestIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.requestIcon.Location = new System.Drawing.Point(-2020, -1010);
            this.requestIcon.Name = "requestIcon";
            this.requestIcon.Size = new System.Drawing.Size(30, 30);
            this.requestIcon.TabIndex = 14;
            this.requestIcon.TabStop = false;
            // 
            // scheduledIcon
            // 
            this.scheduledIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scheduledIcon.BackgroundImage")));
            this.scheduledIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scheduledIcon.Location = new System.Drawing.Point(-2020, -1070);
            this.scheduledIcon.Name = "scheduledIcon";
            this.scheduledIcon.Size = new System.Drawing.Size(30, 30);
            this.scheduledIcon.TabIndex = 13;
            this.scheduledIcon.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2044, -957);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 49);
            this.label6.TabIndex = 11;
            this.label6.Text = "Requested";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2044, -1018);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 49);
            this.label5.TabIndex = 10;
            this.label5.Text = "On Going";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduledMaintenance
            // 
            this.lblScheduledMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduledMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledMaintenance.Location = new System.Drawing.Point(-2044, -1076);
            this.lblScheduledMaintenance.Name = "lblScheduledMaintenance";
            this.lblScheduledMaintenance.Size = new System.Drawing.Size(267, 49);
            this.lblScheduledMaintenance.TabIndex = 9;
            this.lblScheduledMaintenance.Text = "Scheduled";
            this.lblScheduledMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2039, -1110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maintenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.rooms_Admin_UC1);
            this.panel4.Controls.Add(this.dashboardMaintenance1);
            this.panel4.Location = new System.Drawing.Point(304, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1604, 1011);
            this.panel4.TabIndex = 24;
            // 
            // dashboardMaintenance1
            // 
            this.dashboardMaintenance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardMaintenance1.Location = new System.Drawing.Point(0, 0);
            this.dashboardMaintenance1.Name = "dashboardMaintenance1";
            this.dashboardMaintenance1.Size = new System.Drawing.Size(1604, 1011);
            this.dashboardMaintenance1.TabIndex = 1;
            // 
            // rooms_Admin_UC1
            // 
            this.rooms_Admin_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rooms_Admin_UC1.Location = new System.Drawing.Point(0, 0);
            this.rooms_Admin_UC1.Name = "rooms_Admin_UC1";
            this.rooms_Admin_UC1.Size = new System.Drawing.Size(1604, 1011);
            this.rooms_Admin_UC1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1460, 920);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onGoingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Windows.Forms.PictureBox ExitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        internal Windows.Forms.Timer timerSched;
        internal Windows.Forms.Timer timerOnGoing;
        internal Windows.Forms.Timer timerReq;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Label lblName;
        private Windows.Forms.Panel panel3;
        private Windows.Forms.Label label1;
        private Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button maintenanceTab;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Windows.Forms.PictureBox onGoingIcon;
        private Windows.Forms.PictureBox requestIcon;
        private Windows.Forms.PictureBox scheduledIcon;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label lblScheduledMaintenance;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Windows.Forms.Panel panel4;
        private Rooms_Admin_UC rooms_Admin_UC1;
        private DashboardMaintenance dashboardMaintenance1;
    }
}