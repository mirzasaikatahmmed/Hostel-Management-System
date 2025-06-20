using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Hostel_Management_System
{
    public partial class Registration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;
        public Registration()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        string userQuery = @"INSERT INTO Users (Username, Email, Password, Role)
                                     VALUES (@Username, @Email, @Password, 'Student');
                                     SELECT SCOPE_IDENTITY();";

                        SqlCommand userCmd = new SqlCommand(userQuery, con, transaction);
                        userCmd.Parameters.AddWithValue("@Username", name);
                        userCmd.Parameters.AddWithValue("@Email", email);
                        userCmd.Parameters.AddWithValue("@Password", password);

                        int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                        string studentQuery = @"INSERT INTO Students (Name, Email, Phone, AssignedRoomID, UserID)
                                        VALUES (@Name, @Email, NULL, NULL, @UserID)";

                        SqlCommand studentCmd = new SqlCommand(studentQuery, con, transaction);
                        studentCmd.Parameters.AddWithValue("@Name", name);
                        studentCmd.Parameters.AddWithValue("@Email", email);
                        studentCmd.Parameters.AddWithValue("@UserID", userId);

                        int result = studentCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            transaction.Commit();
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Student registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception innerEx)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Transaction failed: " + innerEx.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
