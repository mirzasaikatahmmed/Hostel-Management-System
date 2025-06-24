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
    public partial class AddEditStaffForm : Form
    {
        private readonly StaffController staffController;
        private readonly int? staffId;
        private bool isUpdateMode = false;
        public AddEditStaffForm()
        {
            InitializeComponent();
            staffController = new StaffController();
        }
        public AddEditStaffForm(int staffId) : this()
        {
            this.staffId = staffId;
            isUpdateMode = true;
            LoadStaffData();
        }
        private void LoadStaffData()
        {
            var staff = staffController.GetStaffById(staffId.Value);
            if (staff != null)
            {
                nameTextBox.Text = staff.Name;
                contactNoTextBox.Text = staff.Phone;
                emailTextBox.Text = staff.Email;
                passwordTextBox.Text = staff.Password;
            }
        }

        private void updateStudentBTN_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string phone = contactNoTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StaffModel model = new StaffModel
            {
                StaffID = staffId ?? 0,
                Name = name,
                Phone = phone,
                Email = email,
                Password = password
            };

            bool success;
            if (isUpdateMode)
                success = staffController.UpdateStaff(model);
            else
                success = staffController.AddStaff(model);

            if (success)
            {
                MessageBox.Show(isUpdateMode ? "Staff updated!" : "Staff added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
