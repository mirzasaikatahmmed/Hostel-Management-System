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

namespace Hostel_Management_System.Staff
{
    public partial class StaffListForm : Form
    {
        private readonly StaffController staffController;
        public StaffListForm()
        {
            InitializeComponent();
            staffController = new StaffController();
            LoadStaffGrid();
        }

        private void LoadStaffGrid()
        {
            try
            {
                List<StaffModel> staffList = staffController.GetAllStaff();
                staffListDataGridView.DataSource = staffList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addStaffBTN_Click(object sender, EventArgs e)
        {
            AddEditStaffForm form = new AddEditStaffForm();
            form.ShowDialog();
            LoadStaffGrid();
        }

        private void updateStaffBTN_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (staffListDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffListDataGridView.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["StaffID"].Value?.ToString(), out int staffId))
                {
                    AddEditStaffForm editForm = new AddEditStaffForm(staffId);
                    editForm.ShowDialog();
                    LoadStaffGrid();
                }
                else
                {
                    MessageBox.Show("Invalid staff selected. Please ensure the selected row has a valid Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
