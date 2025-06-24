using Hostel_Management_System.Controller;
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
    }
}
