
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
            this.pnlDecoration = new System.Windows.Forms.Panel();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.lblTitleTask = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.pnlTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.pnlTask.SuspendLayout();
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
            // pnlDecoration
            // 
            this.pnlDecoration.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlDecoration.Location = new System.Drawing.Point(465, 59);
            this.pnlDecoration.Name = "pnlDecoration";
            this.pnlDecoration.Size = new System.Drawing.Size(775, 10);
            this.pnlDecoration.TabIndex = 15;
            // 
            // pnlTasks
            // 
            this.pnlTasks.AutoScroll = true;
            this.pnlTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTasks.Controls.Add(this.pnlTask);
            this.pnlTasks.Location = new System.Drawing.Point(32, 241);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1208, 474);
            this.pnlTasks.TabIndex = 16;
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(32, 171);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(155, 46);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 17;
            this.pbxAdd.TabStop = false;
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlTask.Controls.Add(this.lblTitleTask);
            this.pnlTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTask.Location = new System.Drawing.Point(17, 19);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(235, 178);
            this.pnlTask.TabIndex = 0;
            // 
            // lblTitleTask
            // 
            this.lblTitleTask.AutoSize = true;
            this.lblTitleTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleTask.Location = new System.Drawing.Point(12, 12);
            this.lblTitleTask.Name = "lblTitleTask";
            this.lblTitleTask.Size = new System.Drawing.Size(175, 28);
            this.lblTitleTask.TabIndex = 1;
            this.lblTitleTask.Text = "Título de la tarea";
            // 
            // frmPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 776);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pnlTasks);
            this.Controls.Add(this.pnlDecoration);
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
            this.pnlTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Panel pnlDecoration;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Label lblTitleTask;
    }
}