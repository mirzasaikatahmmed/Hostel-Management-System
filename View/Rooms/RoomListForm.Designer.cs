namespace Hostel_Management_System.Rooms
{
    partial class RoomListForm
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
            this.refreshBTN = new System.Windows.Forms.Button();
            this.searchBTN = new System.Windows.Forms.Button();
            this.addRoomBTN = new System.Windows.Forms.Button();
            this.updateRoomBTN = new System.Windows.Forms.Button();
            this.deleteRoomBTN = new System.Windows.Forms.Button();
            this.roomListFormDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomListFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 43);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Room:";
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.roomNoTextBox.Location = new System.Drawing.Point(162, 58);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(162, 31);
            this.roomNoTextBox.TabIndex = 12;
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTN.ForeColor = System.Drawing.Color.White;
            this.refreshBTN.Location = new System.Drawing.Point(565, 52);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(125, 41);
            this.refreshBTN.TabIndex = 23;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = false;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(330, 52);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(125, 41);
            this.searchBTN.TabIndex = 24;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            // 
            // addRoomBTN
            // 
            this.addRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBTN.ForeColor = System.Drawing.Color.White;
            this.addRoomBTN.Location = new System.Drawing.Point(33, 124);
            this.addRoomBTN.Name = "addRoomBTN";
            this.addRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.addRoomBTN.TabIndex = 25;
            this.addRoomBTN.Text = "Add Room";
            this.addRoomBTN.UseVisualStyleBackColor = false;
            // 
            // updateRoomBTN
            // 
            this.updateRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRoomBTN.ForeColor = System.Drawing.Color.White;
            this.updateRoomBTN.Location = new System.Drawing.Point(262, 124);
            this.updateRoomBTN.Name = "updateRoomBTN";
            this.updateRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.updateRoomBTN.TabIndex = 26;
            this.updateRoomBTN.Text = "Update Room";
            this.updateRoomBTN.UseVisualStyleBackColor = false;
            // 
            // deleteRoomBTN
            // 
            this.deleteRoomBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteRoomBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoomBTN.ForeColor = System.Drawing.Color.White;
            this.deleteRoomBTN.Location = new System.Drawing.Point(481, 124);
            this.deleteRoomBTN.Name = "deleteRoomBTN";
            this.deleteRoomBTN.Size = new System.Drawing.Size(194, 51);
            this.deleteRoomBTN.TabIndex = 27;
            this.deleteRoomBTN.Text = "Delete";
            this.deleteRoomBTN.UseVisualStyleBackColor = false;
            // 
            // roomListFormDataGridView
            // 
            this.roomListFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomListFormDataGridView.Location = new System.Drawing.Point(16, 203);
            this.roomListFormDataGridView.Name = "roomListFormDataGridView";
            this.roomListFormDataGridView.RowHeadersWidth = 51;
            this.roomListFormDataGridView.RowTemplate.Height = 24;
            this.roomListFormDataGridView.Size = new System.Drawing.Size(674, 323);
            this.roomListFormDataGridView.TabIndex = 28;
            // 
            // RoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.roomListFormDataGridView);
            this.Controls.Add(this.deleteRoomBTN);
            this.Controls.Add(this.updateRoomBTN);
            this.Controls.Add(this.addRoomBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomListFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button addRoomBTN;
        private System.Windows.Forms.Button updateRoomBTN;
        private System.Windows.Forms.Button deleteRoomBTN;
        private System.Windows.Forms.DataGridView roomListFormDataGridView;
    }
}