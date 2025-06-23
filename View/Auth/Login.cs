using Hostel_Management_System.Controller;
using Hostel_Management_System.Dashboard;
using Hostel_Management_System.Models;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Login : Form
    {
        private readonly AuthController authController;
        public Login()
        {
            InitializeComponent();
            authController = new AuthController();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            UserModel user = authController.Login(email, password);

            if (user != null)
            {
                MessageBox.Show("Login successful! Role: " + user.Role);

                switch (user.Role)
                {
                    case "Admin":
                        new AdminDashboard(user.UserID).Show();
                        break;
                    case "Staff":
                        new StaffDashboard(user.UserID).Show();
                        break;
                    case "Student":
                        new StudentDashboard(user.UserID).Show();
                        break;
                    default:
                        MessageBox.Show("Unknown role: " + user.Role);
                        return;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registerForm = new Registration();
            registerForm.Show();
            this.Hide();
        }
    }
}
