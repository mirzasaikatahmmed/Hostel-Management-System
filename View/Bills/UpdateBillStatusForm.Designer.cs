namespace Hostel_Management_System.Bills
{
    partial class UpdateBillStatusForm
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
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.updateBillStatusFormDataGridView = new System.Windows.Forms.DataGridView();
            this.updateStatusBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateBillStatusFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Utility Bills";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room :";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.roomNoTextBox.Location = new System.Drawing.Point(97, 53);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(100, 31);
            this.roomNoTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Month :";
            // 
            // monthDateTimePicker
            // 
            this.monthDateTimePicker.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.monthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.monthDateTimePicker.Location = new System.Drawing.Point(295, 53);
            this.monthDateTimePicker.Name = "monthDateTimePicker";
            this.monthDateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.monthDateTimePicker.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status :";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(581, 53);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(97, 31);
            this.statusComboBox.TabIndex = 16;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(283, 104);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(194, 51);
            this.searchBTN.TabIndex = 17;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTN.ForeColor = System.Drawing.Color.White;
            this.refreshBTN.Location = new System.Drawing.Point(483, 104);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(194, 51);
            this.refreshBTN.TabIndex = 18;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = false;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // updateBillStatusFormDataGridView
            // 
            this.updateBillStatusFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateBillStatusFormDataGridView.Location = new System.Drawing.Point(12, 178);
            this.updateBillStatusFormDataGridView.Name = "updateBillStatusFormDataGridView";
            this.updateBillStatusFormDataGridView.RowHeadersWidth = 51;
            this.updateBillStatusFormDataGridView.RowTemplate.Height = 24;
            this.updateBillStatusFormDataGridView.Size = new System.Drawing.Size(678, 275);
            this.updateBillStatusFormDataGridView.TabIndex = 19;
            // 
            // updateStatusBTN
            // 
            this.updateStatusBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateStatusBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatusBTN.ForeColor = System.Drawing.Color.White;
            this.updateStatusBTN.Location = new System.Drawing.Point(496, 465);
            this.updateStatusBTN.Name = "updateStatusBTN";
            this.updateStatusBTN.Size = new System.Drawing.Size(194, 51);
            this.updateStatusBTN.TabIndex = 20;
            this.updateStatusBTN.Text = "Update Status";
            this.updateStatusBTN.UseVisualStyleBackColor = false;
            this.updateStatusBTN.Click += new System.EventHandler(this.updateStatusBTN_Click);
            // 
            // UpdateBillStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.updateStatusBTN);
            this.Controls.Add(this.updateBillStatusFormDataGridView);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBillStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBillStatusForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateBillStatusFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker monthDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.DataGridView updateBillStatusFormDataGridView;
        private System.Windows.Forms.Button updateStatusBTN;
    }
}