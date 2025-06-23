using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hostel_Management_System.Controller
{
    public class AuthController
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public UserModel Login(string email, string password)
        {
            UserModel user = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT UserID, Role FROM Users WHERE Email = @Email AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        user = new UserModel
                        {
                            UserID = reader.GetInt32(0),
                            Role = reader.GetString(1),
                            Email = email,
                            Password = password
                        };
                    }
                }
            }

            return user;
        }

        public bool Register(RegistrationModel user, out string errorMessage)
        {
            errorMessage = "";
            bool success = false;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Insert into Users
                    string userQuery = @"INSERT INTO Users (Username, Email, Password, Role)
                                         VALUES (@Username, @Email, @Password, 'Student');
                                         SELECT SCOPE_IDENTITY();";

                    SqlCommand userCmd = new SqlCommand(userQuery, con, transaction);
                    userCmd.Parameters.AddWithValue("@Username", user.Name);
                    userCmd.Parameters.AddWithValue("@Email", user.Email);
                    userCmd.Parameters.AddWithValue("@Password", user.Password);

                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    // Insert into Students
                    string studentQuery = @"INSERT INTO Students (Name, Email, Phone, AssignedRoomID, UserID)
                                            VALUES (@Name, @Email, NULL, NULL, @UserID)";

                    SqlCommand studentCmd = new SqlCommand(studentQuery, con, transaction);
                    studentCmd.Parameters.AddWithValue("@Name", user.Name);
                    studentCmd.Parameters.AddWithValue("@Email", user.Email);
                    studentCmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = studentCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        transaction.Commit();
                        success = true;
                    }
                    else
                    {
                        transaction.Rollback();
                        errorMessage = "Student registration failed.";
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    errorMessage = "Transaction error: " + ex.Message;
                }
            }

            return success;
        }
    }
}
