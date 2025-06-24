using Hostel_Management_System.Controller;
using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Bills
{
    public partial class UpdateBillStatusForm : Form
    {
        private readonly UtilityBillController utilityBillController;
        public UpdateBillStatusForm()
        {
            InitializeComponent();
            utilityBillController = new UtilityBillController();
            InitializeFormControls();
            LoadUtilityBillsGrid();
        }

        private void InitializeFormControls()
        {
            statusComboBox.Items.Add("All");
            statusComboBox.Items.Add("Paid");
            statusComboBox.Items.Add("Unpaid");
            statusComboBox.SelectedIndex = 0;

            monthDateTimePicker.Format = DateTimePickerFormat.Custom;
            monthDateTimePicker.CustomFormat = "MM/yyyy";
            monthDateTimePicker.ShowUpDown = true;
        }

        private void LoadUtilityBillsGrid(int? roomID = null, DateTime? month = null, string status = null)
        {
            try
            {
                List<UtilityBillModel> billList = utilityBillController.GetAllUtilityBills(roomID, month, status);
                updateBillStatusFormDataGridView.DataSource = billList;

                updateBillStatusFormDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load utility bills: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            int? filterRoomID = null;
            DateTime? filterMonth = null;
            string filterStatus = null;

            if (!string.IsNullOrWhiteSpace(roomNoTextBox.Text))
            {
                if (int.TryParse(roomNoTextBox.Text, out int parsedRoomID))
                {
                    filterRoomID = parsedRoomID;
                }
                else
                {
                    MessageBox.Show("Invalid Room ID. Please enter a valid number or leave it empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            filterMonth = new DateTime(monthDateTimePicker.Value.Year, monthDateTimePicker.Value.Month, 1);

            if (statusComboBox.SelectedItem != null && statusComboBox.SelectedItem.ToString() != "All")
            {
                filterStatus = statusComboBox.SelectedItem.ToString();
            }

            LoadUtilityBillsGrid(filterRoomID, filterMonth, filterStatus);
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            roomNoTextBox.Text = string.Empty;
            monthDateTimePicker.Value = DateTime.Now;
            statusComboBox.SelectedIndex = 0;

            LoadUtilityBillsGrid();
        }

        private void updateStatusBTN_Click(object sender, EventArgs e)
        {
            if (updateBillStatusFormDataGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = updateBillStatusFormDataGridView.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["BillID"].Value?.ToString(), out int billId))
                {
                    
                    string currentStatus = selectedRow.Cells["Status"].Value?.ToString();
                    string newStatus = "";

                    using (Form statusDialog = new Form())
                    {
                        statusDialog.Text = "Update Bill Status";
                        statusDialog.StartPosition = FormStartPosition.CenterParent;
                        statusDialog.Width = 300;
                        statusDialog.Height = 150;

                        Label lbl = new Label() { Text = $"Current Status for Bill ID {billId}: {currentStatus}", Location = new Point(10, 10), AutoSize = true };
                        ComboBox cbStatus = new ComboBox() { Location = new Point(10, 40), Width = 200 };
                        cbStatus.Items.Add("Paid");
                        cbStatus.Items.Add("Unpaid");
                        cbStatus.SelectedItem = currentStatus;

                        Button btnOk = new Button() { Text = "OK", Location = new Point(10, 80) };
                        btnOk.Click += (s, ev) => { newStatus = cbStatus.SelectedItem?.ToString(); statusDialog.DialogResult = DialogResult.OK; };

                        Button btnCancel = new Button() { Text = "Cancel", Location = new Point(btnOk.Right + 10, 80) };
                        btnCancel.Click += (s, ev) => { statusDialog.DialogResult = DialogResult.Cancel; };

                        statusDialog.Controls.Add(lbl);
                        statusDialog.Controls.Add(cbStatus);
                        statusDialog.Controls.Add(btnOk);
                        statusDialog.Controls.Add(btnCancel);

                        if (statusDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(newStatus))
                        {
                            bool success = utilityBillController.UpdateUtilityBillStatus(billId, newStatus);

                            if (success)
                            {
                                MessageBox.Show("Bill status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadUtilityBillsGrid();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update bill status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid bill selected. Please ensure the selected row has a valid Bill ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a utility bill to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
