namespace Hostel_Management_System.Students
{
    partial class StudentListForm
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
            this.updateStudentBTN = new System.Windows.Forms.Button();
            this.addStudentBTN = new System.Windows.Forms.Button();
            this.studentListDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBTN);
            this.panel2.Controls.Add(this.updateStudentBTN);
            this.panel2.Controls.Add(this.addStudentBTN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 70);
            this.panel2.TabIndex = 2;
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
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // updateStudentBTN
            // 
            this.updateStudentBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateStudentBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentBTN.ForeColor = System.Drawing.Color.White;
            this.updateStudentBTN.Location = new System.Drawing.Point(249, 9);
            this.updateStudentBTN.Name = "updateStudentBTN";
            this.updateStudentBTN.Size = new System.Drawing.Size(194, 51);
            this.updateStudentBTN.TabIndex = 15;
            this.updateStudentBTN.Text = "Update";
            this.updateStudentBTN.UseVisualStyleBackColor = false;
            this.updateStudentBTN.Click += new System.EventHandler(this.updateStudentBTN_Click);
            // 
            // addStudentBTN
            // 
            this.addStudentBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.addStudentBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBTN.ForeColor = System.Drawing.Color.White;
            this.addStudentBTN.Location = new System.Drawing.Point(49, 9);
            this.addStudentBTN.Name = "addStudentBTN";
            this.addStudentBTN.Size = new System.Drawing.Size(194, 51);
            this.addStudentBTN.TabIndex = 14;
            this.addStudentBTN.Text = "Add";
            this.addStudentBTN.UseVisualStyleBackColor = false;
            this.addStudentBTN.Click += new System.EventHandler(this.addStudentBTN_Click);
            // 
            // studentListDataGridView
            // 
            this.studentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDataGridView.Location = new System.Drawing.Point(12, 119);
            this.studentListDataGridView.Name = "studentListDataGridView";
            this.studentListDataGridView.RowHeadersWidth = 51;
            this.studentListDataGridView.RowTemplate.Height = 24;
            this.studentListDataGridView.Size = new System.Drawing.Size(678, 407);
            this.studentListDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Management System";
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.studentListDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentListForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button updateStudentBTN;
        private System.Windows.Forms.Button addStudentBTN;
        private System.Windows.Forms.DataGridView studentListDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}