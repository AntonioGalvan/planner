
namespace Planner
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxView = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.pbxExit = new System.Windows.Forms.PictureBox();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.pbxDecoration1 = new System.Windows.Forms.PictureBox();
            this.pbxDecoration2 = new System.Windows.Forms.PictureBox();
            this.pnlFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).BeginInit();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoration2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(439, 288);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(224, 197);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAdd.TabIndex = 0;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxView
            // 
            this.pbxView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxView.Image = ((System.Drawing.Image)(resources.GetObject("pbxView.Image")));
            this.pbxView.Location = new System.Drawing.Point(714, 288);
            this.pbxView.Name = "pbxView";
            this.pbxView.Size = new System.Drawing.Size(224, 197);
            this.pbxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxView.TabIndex = 1;
            this.pbxView.TabStop = false;
            this.pbxView.Click += new System.EventHandler(this.pbxView_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(591, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 81);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Planner";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(468, 71);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(135, 86);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 10;
            this.pbxLogo.TabStop = false;
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcon.Image")));
            this.pbxIcon.Location = new System.Drawing.Point(769, 118);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(123, 86);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcon.TabIndex = 11;
            this.pbxIcon.TabStop = false;
            // 
            // pbxExit
            // 
            this.pbxExit.BackColor = System.Drawing.Color.Transparent;
            this.pbxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxExit.Image = ((System.Drawing.Image)(resources.GetObject("pbxExit.Image")));
            this.pbxExit.Location = new System.Drawing.Point(86, 7);
            this.pbxExit.Name = "pbxExit";
            this.pbxExit.Size = new System.Drawing.Size(27, 29);
            this.pbxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExit.TabIndex = 13;
            this.pbxExit.TabStop = false;
            this.pbxExit.Click += new System.EventHandler(this.pbxExit_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.IndianRed;
            this.pnlExit.Controls.Add(this.lblExit);
            this.pnlExit.Controls.Add(this.pbxExit);
            this.pnlExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlExit.Location = new System.Drawing.Point(1206, 663);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(125, 42);
            this.pnlExit.TabIndex = 17;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.IndianRed;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblExit.Location = new System.Drawing.Point(15, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(65, 32);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "Salir";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pbxDecoration1
            // 
            this.pbxDecoration1.Image = ((System.Drawing.Image)(resources.GetObject("pbxDecoration1.Image")));
            this.pbxDecoration1.Location = new System.Drawing.Point(-182, -10);
            this.pbxDecoration1.Name = "pbxDecoration1";
            this.pbxDecoration1.Size = new System.Drawing.Size(454, 740);
            this.pbxDecoration1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDecoration1.TabIndex = 20;
            this.pbxDecoration1.TabStop = false;
            // 
            // pbxDecoration2
            // 
            this.pbxDecoration2.Image = ((System.Drawing.Image)(resources.GetObject("pbxDecoration2.Image")));
            this.pbxDecoration2.Location = new System.Drawing.Point(1074, -10);
            this.pbxDecoration2.Name = "pbxDecoration2";
            this.pbxDecoration2.Size = new System.Drawing.Size(451, 740);
            this.pbxDecoration2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDecoration2.TabIndex = 21;
            this.pbxDecoration2.TabStop = false;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFondo.Location = new System.Drawing.Point(376, 247);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(632, 284);
            this.pnlFondo.TabIndex = 18;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 717);
            this.Controls.Add(this.pbxDecoration1);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxView);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.pbxDecoration2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planner";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExit)).EndInit();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDecoration2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.PictureBox pbxExit;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pbxDecoration1;
        private System.Windows.Forms.PictureBox pbxDecoration2;
        private System.Windows.Forms.Panel pnlFondo;
    }
}

