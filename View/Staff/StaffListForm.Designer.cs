namespace Hostel_Management_System.Staff
{
    partial class StaffListForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.updateStaffBTN = new System.Windows.Forms.Button();
            this.addStaffBTN = new System.Windows.Forms.Button();
            this.staffListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBTN);
            this.panel2.Controls.Add(this.updateStaffBTN);
            this.panel2.Controls.Add(this.addStaffBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 70);
            this.panel2.TabIndex = 5;
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTN.ForeColor = System.Drawing.Color.White;
            this.refreshBTN.Location = new System.Drawing.Point(449, 9);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(194, 51);
            this.refreshBTN.TabIndex = 16;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = false;
            // 
            // updateStaffBTN
            // 
            this.updateStaffBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateStaffBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaffBTN.ForeColor = System.Drawing.Color.White;
            this.updateStaffBTN.Location = new System.Drawing.Point(249, 9);
            this.updateStaffBTN.Name = "updateStaffBTN";
            this.updateStaffBTN.Size = new System.Drawing.Size(194, 51);
            this.updateStaffBTN.TabIndex = 15;
            this.updateStaffBTN.Text = "Update";
            this.updateStaffBTN.UseVisualStyleBackColor = false;
            this.updateStaffBTN.Click += new System.EventHandler(this.updateStaffBTN_Click);
            // 
            // addStaffBTN
            // 
            this.addStaffBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.addStaffBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffBTN.ForeColor = System.Drawing.Color.White;
            this.addStaffBTN.Location = new System.Drawing.Point(49, 9);
            this.addStaffBTN.Name = "addStaffBTN";
            this.addStaffBTN.Size = new System.Drawing.Size(194, 51);
            this.addStaffBTN.TabIndex = 14;
            this.addStaffBTN.Text = "Add";
            this.addStaffBTN.UseVisualStyleBackColor = false;
            this.addStaffBTN.Click += new System.EventHandler(this.addStaffBTN_Click);
            // 
            // staffListDataGridView
            // 
            this.staffListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffListDataGridView.Location = new System.Drawing.Point(12, 125);
            this.staffListDataGridView.Name = "staffListDataGridView";
            this.staffListDataGridView.RowHeadersWidth = 51;
            this.staffListDataGridView.RowTemplate.Height = 24;
            this.staffListDataGridView.Size = new System.Drawing.Size(678, 407);
            this.staffListDataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Staff Management System";
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.staffListDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffListForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button updateStaffBTN;
        private System.Windows.Forms.Button addStaffBTN;
        private System.Windows.Forms.DataGridView staffListDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}