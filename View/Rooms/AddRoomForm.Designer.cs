namespace Hostel_Management_System.View.Rooms
{
    partial class AddRoomForm
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
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addRoomBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Room";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closePictureBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 5;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Image = global::Hostel_Management_System.Properties.Resources.icons8_cross_96;
            this.closePictureBox.Location = new System.Drawing.Point(667, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(35, 35);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 27;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Room No :";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.roomNoTextBox.Location = new System.Drawing.Point(131, 71);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(132, 31);
            this.roomNoTextBox.TabIndex = 29;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.capacityTextBox.Location = new System.Drawing.Point(131, 120);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(132, 31);
            this.capacityTextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Capacity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Status :";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(131, 172);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(132, 31);
            this.statusComboBox.TabIndex = 33;
            // 
            // addRoomBTN
            // 
            this.addRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBTN.ForeColor = System.Drawing.Color.White;
            this.addRoomBTN.Location = new System.Drawing.Point(69, 223);
            this.addRoomBTN.Name = "addRoomBTN";
            this.addRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.addRoomBTN.TabIndex = 34;
            this.addRoomBTN.Text = "Add Room";
            this.addRoomBTN.UseVisualStyleBackColor = false;
            this.addRoomBTN.Click += new System.EventHandler(this.addRoomBTN_Click);
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.addRoomBTN);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoomForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button addRoomBTN;
    }
}