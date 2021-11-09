
namespace Planner
{
    partial class frmPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanner));
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxClose
            // 
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(1291, 12);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(26, 25);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 0;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(15, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(135, 86);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(138, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 81);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Planner";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcon.Image")));
            this.pbxIcon.Location = new System.Drawing.Point(316, 59);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(123, 86);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcon.TabIndex = 14;
            this.pbxIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(465, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 10);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(15, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 474);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 776);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.pbxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planner";
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}