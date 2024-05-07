
namespace System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.roomNumberPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.roomNumber = new System.Windows.Forms.Label();
            this.roomInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roomImage = new System.Windows.Forms.PictureBox();
            this.roomNumberPanel.SuspendLayout();
            this.roomInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNumberPanel
            // 
            this.roomNumberPanel.BackColor = System.Drawing.Color.DimGray;
            this.roomNumberPanel.BorderColor = System.Drawing.Color.Transparent;
            this.roomNumberPanel.BorderRadius = 2;
            this.roomNumberPanel.BorderThickness = 1;
            this.roomNumberPanel.Controls.Add(this.roomNumber);
            this.roomNumberPanel.Location = new System.Drawing.Point(-68, 324);
            this.roomNumberPanel.Name = "roomNumberPanel";
            this.roomNumberPanel.Size = new System.Drawing.Size(936, 48);
            this.roomNumberPanel.TabIndex = 12;
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSize = true;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.roomNumber.Location = new System.Drawing.Point(13, 12);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(0, 24);
            this.roomNumber.TabIndex = 0;
            // 
            // roomInformation
            // 
            this.roomInformation.BackColor = System.Drawing.Color.Transparent;
            this.roomInformation.BorderColor = System.Drawing.Color.Gray;
            this.roomInformation.BorderRadius = 5;
            this.roomInformation.BorderThickness = 1;
            this.roomInformation.Controls.Add(this.label31);
            this.roomInformation.Controls.Add(this.label30);
            this.roomInformation.Controls.Add(this.label9);
            this.roomInformation.Controls.Add(this.roomImage);
            this.roomInformation.FillColor = System.Drawing.Color.White;
            this.roomInformation.Location = new System.Drawing.Point(-68, -165);
            this.roomInformation.Name = "roomInformation";
            this.roomInformation.Size = new System.Drawing.Size(936, 999);
            this.roomInformation.TabIndex = 13;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(14, 904);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 18);
            this.label31.TabIndex = 4;
            this.label31.Text = "PRICE";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(14, 768);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(152, 18);
            this.label30.TabIndex = 3;
            this.label30.Text = "ROOM AMENITIES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 647);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ROOM CAPACITY";
            // 
            // roomImage
            // 
            this.roomImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomImage.BackgroundImage")));
            this.roomImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomImage.Location = new System.Drawing.Point(0, 0);
            this.roomImage.Name = "roomImage";
            this.roomImage.Size = new System.Drawing.Size(981, 497);
            this.roomImage.TabIndex = 0;
            this.roomImage.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 925);
            this.Controls.Add(this.roomNumberPanel);
            this.Controls.Add(this.roomInformation);
            this.Name = "Form3";
            this.Text = "Form3";
            this.roomNumberPanel.ResumeLayout(false);
            this.roomNumberPanel.PerformLayout();
            this.roomInformation.ResumeLayout(false);
            this.roomInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel roomNumberPanel;
        private Windows.Forms.Label roomNumber;
        private Guna.UI2.WinForms.Guna2Panel roomInformation;
        private Windows.Forms.Label label31;
        private Windows.Forms.Label label30;
        private Windows.Forms.Label label9;
        private Windows.Forms.PictureBox roomImage;
    }
}