using Hostel_Management_System.Staff;
using Hostel_Management_System.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Hostel_Management_System.Dashboard
{
    string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;
    private int currentUserId = 0;
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(int userID)
        {
            InitializeComponent();
            currentUserId = userID;
        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFormInPanel(Form form)
        {
            dashboardPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(form);
            form.Show();
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {

        }

        private void studentsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new StudentListForm());
        }

        private void staffsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new StaffListForm());
        }

        private void assignRoomBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Rooms.AssignRoomForm());
        }

        private void allServicesBTN_Click(object sender, EventArgs e)
        {

        }

        private void utilityBillBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Bills.UtilityBillListForm());
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
