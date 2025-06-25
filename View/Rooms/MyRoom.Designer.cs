namespace Hostel_Management_System.View.Rooms
{
    partial class MyRoom
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
            this.refreshBTN = new System.Windows.Forms.Button();
            this.myRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myRoomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "My Room";
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
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshBTN.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBTN.ForeColor = System.Drawing.Color.White;
            this.refreshBTN.Location = new System.Drawing.Point(565, 49);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(125, 41);
            this.refreshBTN.TabIndex = 24;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.UseVisualStyleBackColor = false;
            // 
            // myRoomDataGridView
            // 
            this.myRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRoomDataGridView.Location = new System.Drawing.Point(14, 108);
            this.myRoomDataGridView.Name = "myRoomDataGridView";
            this.myRoomDataGridView.RowHeadersWidth = 51;
            this.myRoomDataGridView.RowTemplate.Height = 24;
            this.myRoomDataGridView.Size = new System.Drawing.Size(674, 418);
            this.myRoomDataGridView.TabIndex = 29;
            // 
            // MyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.myRoomDataGridView);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRoom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myRoomDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.DataGridView myRoomDataGridView;
    }
}