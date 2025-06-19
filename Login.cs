using Hostel_Management_System.Dashboard;
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
        string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT UserID, Role FROM Users WHERE Email = @email AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int userId = dr.GetInt32(0);
                    string role = dr.GetString(1);

                    MessageBox.Show("Login successful! Role: " + role);

                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Staff")
                    {
                        StaffDashboard investigator = new StaffDashboard();
                        investigator.Show();
                        this.Hide();
                    }
                    else if (role == "Student")
                    {
                        StudentDashboard reporter = new StudentDashboard();
                        reporter.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role: " + role);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
