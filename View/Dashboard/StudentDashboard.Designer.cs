namespace Hostel_Management_System.Dashboard
{
    partial class StudentDashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.allServicesBTN = new System.Windows.Forms.Button();
            this.myRoomBTN = new System.Windows.Forms.Button();
            this.dashboardBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hotel Management System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutPictureBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 42);
            this.panel1.TabIndex = 1;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.Image = global::Hostel_Management_System.Properties.Resources.icons8_logout_100;
            this.logoutPictureBox.Location = new System.Drawing.Point(915, 3);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(35, 35);
            this.logoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPictureBox.TabIndex = 10;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.pictureBox2);
            this.sidebarPanel.Controls.Add(this.allServicesBTN);
            this.sidebarPanel.Controls.Add(this.myRoomBTN);
            this.sidebarPanel.Controls.Add(this.dashboardBTN);
            this.sidebarPanel.Controls.Add(this.label1);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 42);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(248, 538);
            this.sidebarPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hostel_Management_System.Properties.Resources.icons8_hostel_100;
            this.pictureBox2.Location = new System.Drawing.Point(80, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // allServicesBTN
            // 
            this.allServicesBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.allServicesBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allServicesBTN.ForeColor = System.Drawing.Color.White;
            this.allServicesBTN.Location = new System.Drawing.Point(26, 282);
            this.allServicesBTN.Name = "allServicesBTN";
            this.allServicesBTN.Size = new System.Drawing.Size(194, 51);
            this.allServicesBTN.TabIndex = 16;
            this.allServicesBTN.Text = "All Services";
            this.allServicesBTN.UseVisualStyleBackColor = false;
            this.allServicesBTN.Click += new System.EventHandler(this.allServicesBTN_Click);
            // 
            // myRoomBTN
            // 
            this.myRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.myRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRoomBTN.ForeColor = System.Drawing.Color.White;
            this.myRoomBTN.Location = new System.Drawing.Point(26, 225);
            this.myRoomBTN.Name = "myRoomBTN";
            this.myRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.myRoomBTN.TabIndex = 15;
            this.myRoomBTN.Text = "My Room";
            this.myRoomBTN.UseVisualStyleBackColor = false;
            this.myRoomBTN.Click += new System.EventHandler(this.myRoomBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.dashboardBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.ForeColor = System.Drawing.Color.White;
            this.dashboardBTN.Location = new System.Drawing.Point(26, 168);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(194, 51);
            this.dashboardBTN.TabIndex = 12;
            this.dashboardBTN.Text = "Dashboard";
            this.dashboardBTN.UseVisualStyleBackColor = false;
            this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hotel Management\r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.userNameLabel);
            this.dashboardPanel.Controls.Add(this.label3);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(248, 42);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(702, 538);
            this.dashboardPanel.TabIndex = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(112, 5);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(34, 23);
            this.userNameLabel.TabIndex = 19;
            this.userNameLabel.Text = "[x]";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Welcome,";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoutPictureBox;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button allServicesBTN;
        private System.Windows.Forms.Button myRoomBTN;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label3;
    }
}