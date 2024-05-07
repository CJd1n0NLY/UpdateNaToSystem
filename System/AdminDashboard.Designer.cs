
namespace System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.onGoingIcon = new System.Windows.Forms.PictureBox();
            this.requestIcon = new System.Windows.Forms.PictureBox();
            this.scheduledIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScheduledMaintenance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.editAccountLogin_UC1 = new System.EditAccountLogin_UC();
            this.maintenance_UC1 = new System.Maintenance_UC();
            this.editRooms_UC1 = new System.EditRooms_UC();
            this.userInformation_UC1 = new System.UserInformation_UC();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onGoingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 147);
            this.panel1.TabIndex = 21;
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
            this.panel2.Controls.Add(this.guna2Button9);
            this.panel2.Controls.Add(this.guna2Button8);
            this.panel2.Controls.Add(this.guna2Button7);
            this.panel2.Controls.Add(this.guna2Button6);
            this.panel2.Controls.Add(this.guna2Button5);
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.onGoingIcon);
            this.panel2.Controls.Add(this.requestIcon);
            this.panel2.Controls.Add(this.scheduledIcon);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblScheduledMaintenance);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(-1, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 927);
            this.panel2.TabIndex = 20;
            // 
            // guna2Button9
            // 
            this.guna2Button9.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button9.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button9.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button9.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button9.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.Black;
            this.guna2Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button9.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button9.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.Image")));
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button9.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button9.Location = new System.Drawing.Point(1, 511);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(284, 50);
            this.guna2Button9.TabIndex = 38;
            this.guna2Button9.Text = "Edit Account";
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button9.CheckedChanged += new System.EventHandler(this.guna2Button9_CheckedChanged);
            // 
            // guna2Button8
            // 
            this.guna2Button8.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button8.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button8.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button8.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button8.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Black;
            this.guna2Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button8.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button8.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button8.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button8.Image")));
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button8.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button8.Location = new System.Drawing.Point(1, 461);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(284, 50);
            this.guna2Button8.TabIndex = 37;
            this.guna2Button8.Text = "User Information";
            this.guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button8.CheckedChanged += new System.EventHandler(this.guna2Button8_CheckedChanged);
            // 
            // guna2Button7
            // 
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button7.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button7.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button7.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Black;
            this.guna2Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button7.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button7.Location = new System.Drawing.Point(1, 411);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(284, 50);
            this.guna2Button7.TabIndex = 36;
            this.guna2Button7.Text = "Audit Log";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Button6
            // 
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button6.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button6.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Black;
            this.guna2Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button6.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button6.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button6.Location = new System.Drawing.Point(0, 297);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(284, 50);
            this.guna2Button6.TabIndex = 35;
            this.guna2Button6.Text = "Income";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Button5
            // 
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button5.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(0, 247);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(284, 50);
            this.guna2Button5.TabIndex = 34;
            this.guna2Button5.Text = "Operating Rooms";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button5.CheckedChanged += new System.EventHandler(this.guna2Button5_CheckedChanged);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button4.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(0, 197);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(284, 50);
            this.guna2Button4.TabIndex = 33;
            this.guna2Button4.Text = "Booking History";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button4.CheckedChanged += new System.EventHandler(this.guna2Button4_CheckedChanged);
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2Button3.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(0, 98);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(284, 50);
            this.guna2Button3.TabIndex = 32;
            this.guna2Button3.Text = "Maintenance";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button3.CheckedChanged += new System.EventHandler(this.guna2Button3_CheckedChanged);
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
            this.guna2Button2.Text = "Edit Room";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextOffset = new System.Drawing.Point(5, 0);
            this.guna2Button2.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Maintenance";
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
            this.panel4.Controls.Add(this.editAccountLogin_UC1);
            this.panel4.Controls.Add(this.maintenance_UC1);
            this.panel4.Controls.Add(this.editRooms_UC1);
            this.panel4.Controls.Add(this.userInformation_UC1);
            this.panel4.Location = new System.Drawing.Point(286, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1634, 1037);
            this.panel4.TabIndex = 22;
            // 
            // editAccountLogin_UC1
            // 
            this.editAccountLogin_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editAccountLogin_UC1.Location = new System.Drawing.Point(0, 0);
            this.editAccountLogin_UC1.Name = "editAccountLogin_UC1";
            this.editAccountLogin_UC1.Size = new System.Drawing.Size(1634, 1037);
            this.editAccountLogin_UC1.TabIndex = 3;
            this.editAccountLogin_UC1.Load += new System.EventHandler(this.editAccountLogin_UC1_Load);
            // 
            // maintenance_UC1
            // 
            this.maintenance_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenance_UC1.Location = new System.Drawing.Point(0, 0);
            this.maintenance_UC1.Margin = new System.Windows.Forms.Padding(2);
            this.maintenance_UC1.Name = "maintenance_UC1";
            this.maintenance_UC1.Size = new System.Drawing.Size(1634, 1037);
            this.maintenance_UC1.TabIndex = 1;
            this.maintenance_UC1.Load += new System.EventHandler(this.maintenance_UC1_Load);
            // 
            // editRooms_UC1
            // 
            this.editRooms_UC1.BackColor = System.Drawing.SystemColors.Control;
            this.editRooms_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editRooms_UC1.Location = new System.Drawing.Point(0, 0);
            this.editRooms_UC1.Margin = new System.Windows.Forms.Padding(2);
            this.editRooms_UC1.Name = "editRooms_UC1";
            this.editRooms_UC1.Size = new System.Drawing.Size(1634, 1037);
            this.editRooms_UC1.TabIndex = 0;
            // 
            // userInformation_UC1
            // 
            this.userInformation_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInformation_UC1.Location = new System.Drawing.Point(0, 0);
            this.userInformation_UC1.Name = "userInformation_UC1";
            this.userInformation_UC1.Size = new System.Drawing.Size(1634, 1037);
            this.userInformation_UC1.TabIndex = 2;
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
            this.flowLayoutPanel1.TabIndex = 23;
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
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 920);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onGoingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Label lblName;
        private Windows.Forms.Panel panel3;
        private Windows.Forms.Label label1;
        private Windows.Forms.Panel panel2;
        private Windows.Forms.Label label14;
        private Windows.Forms.Label label9;
        private Windows.Forms.PictureBox onGoingIcon;
        private Windows.Forms.PictureBox requestIcon;
        private Windows.Forms.PictureBox scheduledIcon;
        private Windows.Forms.Label label6;
        private Windows.Forms.Label label5;
        private Windows.Forms.Label lblScheduledMaintenance;
        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Windows.Forms.Panel panel4;
        private EditRooms_UC editRooms_UC1;
        private Maintenance_UC maintenance_UC1;
        private Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Windows.Forms.PictureBox ExitBtn;
        private UserInformation_UC userInformation_UC1;
        private EditAccountLogin_UC editAccountLogin_UC1;
    }
}