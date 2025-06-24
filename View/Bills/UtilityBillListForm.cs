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
    public partial class UtilityBillListForm : Form
    {
        private readonly UtilityBillController utilityBillController;
        private int? billIdToEdit;
        public UtilityBillListForm()
        {
            InitializeComponent();
            utilityBillController = new UtilityBillController();
            InitializeFormControls();
            billIdToEdit = null;
        }
        public UtilityBillListForm(int billId)
        {
            InitializeComponent();
            utilityBillController = new UtilityBillController();
            InitializeFormControls();
            billIdToEdit = billId;
            LoadBillDetails();
        }
        private void InitializeFormControls()
        {
            statusComboBox.Items.Add("Paid");
            statusComboBox.Items.Add("Unpaid");
            if (statusComboBox.Items.Count > 0)
            {
                statusComboBox.SelectedIndex = 0;
            }

            monthDateTimePicker.Format = DateTimePickerFormat.Custom;
            monthDateTimePicker.CustomFormat = "MM/yyyy";
            monthDateTimePicker.ShowUpDown = true;
        }

        private void LoadBillDetails()
        {
            if (billIdToEdit.HasValue)
            {
                try
                {
                    UtilityBillModel bill = utilityBillController.GetUtilityBillById(billIdToEdit.Value);
                    if (bill != null)
                    {
                        roomNoTextBox.Text = bill.RoomID.ToString();
                        monthDateTimePicker.Value = bill.Month;
                        electricityTextBox.Text = bill.Electricity.ToString();
                        waterTextBox.Text = bill.Water.ToString();
                        gasTextBox.Text = bill.Gas.ToString();
                        statusComboBox.SelectedItem = bill.Status;
                    }
                    else
                    {
                        MessageBox.Show("Utility Bill not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load bill details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(roomNoTextBox.Text, out int roomID))
            {
                MessageBox.Show("Please enter a valid Room Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(electricityTextBox.Text, out decimal electricity) || electricity < 0)
            {
                MessageBox.Show("Please enter a valid positive value for Electricity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(waterTextBox.Text, out decimal water) || water < 0)
            {
                MessageBox.Show("Please enter a valid positive value for Water.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(gasTextBox.Text, out decimal gas) || gas < 0)
            {
                MessageBox.Show("Please enter a valid positive value for Gas.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = statusComboBox.SelectedItem.ToString();

            UtilityBillModel bill = new UtilityBillModel
            {
                RoomID = roomID,
                Month = new DateTime(monthDateTimePicker.Value.Year, monthDateTimePicker.Value.Month, 1),
                Electricity = electricity,
                Water = water,
                Gas = gas,
                Status = status
            };

            bool success = false;
            try
            {
                if (billIdToEdit.HasValue)
                {
                    bill.BillID = billIdToEdit.Value;
                    success = utilityBillController.UpdateUtilityBill(bill);
                    if (success)
                    {
                        MessageBox.Show("Utility Bill updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update utility bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    success = utilityBillController.AddUtilityBill(bill);
                    if (success)
                    {
                        MessageBox.Show("New Utility Bill added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new utility bill.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}