using Hostel_Management_System.Controller;
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

namespace Hostel_Management_System.Dashboard
{
    public partial class StaffDashboard : Form
    {
        private int currentUserId;  
        public StaffDashboard()
        {
            InitializeComponent();
        }

        public StaffDashboard(int UserID)
        {
            InitializeComponent();
            currentUserId = UserID;
            LoadUsername();
        }
        private void LoadUsername()
        {
            UserController userController = new UserController();
            string username = userController.FetchUsername(currentUserId);

            userNameLabel.Text = $"{username}";
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
            LoadFormInPanel(new StaffDashboard(currentUserId));
        }

        private void studentsBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new StudentListForm());
        }

        private void assignRoomBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Rooms.RoomListForm());
        }

        private void allServicesBTN_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Requests.ViewRequestStatusForm());
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
