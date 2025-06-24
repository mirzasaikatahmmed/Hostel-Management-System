namespace Hostel_Management_System.Rooms
{
    partial class AssignRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.assignRoomBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Assign Room to Student  ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Name       :";
            // 
            // studentNameComboBox
            // 
            this.studentNameComboBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.studentNameComboBox.FormattingEnabled = true;
            this.studentNameComboBox.Location = new System.Drawing.Point(216, 55);
            this.studentNameComboBox.Name = "studentNameComboBox";
            this.studentNameComboBox.Size = new System.Drawing.Size(474, 31);
            this.studentNameComboBox.TabIndex = 12;
            this.studentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.studentNameComboBox_SelectedIndexChanged);
            // 
            // roomComboBox
            // 
            this.roomComboBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(216, 107);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(474, 31);
            this.roomComboBox.TabIndex = 14;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Room        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Date         :";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.startDateTimePicker.Location = new System.Drawing.Point(216, 161);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(474, 31);
            this.startDateTimePicker.TabIndex = 16;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.endDateTimePicker.Location = new System.Drawing.Point(216, 212);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(474, 31);
            this.endDateTimePicker.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date           :";
            // 
            // assignRoomBTN
            // 
            this.assignRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.assignRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignRoomBTN.ForeColor = System.Drawing.Color.White;
            this.assignRoomBTN.Location = new System.Drawing.Point(496, 273);
            this.assignRoomBTN.Name = "assignRoomBTN";
            this.assignRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.assignRoomBTN.TabIndex = 28;
            this.assignRoomBTN.Text = "Assign Room";
            this.assignRoomBTN.UseVisualStyleBackColor = false;
            this.assignRoomBTN.Click += new System.EventHandler(this.assignRoomBTN_Click);
            // 
            // AssignRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.assignRoomBTN);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentNameComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignRoomForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentNameComboBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button assignRoomBTN;
    }
}