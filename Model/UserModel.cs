using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hostel_Management_System.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        private readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static UserModel LoginUser(string email, string password)
        {
            UserModel user = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString))
            {
                string query = "SELECT UserID, Role, Email, Password FROM Users WHERE Email = @Email AND Password = @Password";
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
                            Email = reader.GetString(2),
                            Password = reader.GetString(3)
                        };
                    }
                }
            }

            return user;
        }

        public static bool RegisterUser(RegistrationModel newUser, out string errorMessage)
        {
            errorMessage = "";
            bool success = false;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string userQuery = @"INSERT INTO Users (Username, Email, Password, Role)
                                         VALUES (@Username, @Email, @Password, 'Student');
                                         SELECT SCOPE_IDENTITY();";

                    SqlCommand userCmd = new SqlCommand(userQuery, con, transaction);
                    userCmd.Parameters.AddWithValue("@Username", newUser.Name);
                    userCmd.Parameters.AddWithValue("@Email", newUser.Email);
                    userCmd.Parameters.AddWithValue("@Password", newUser.Password);

                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    string studentQuery = @"INSERT INTO Students (Name, Email, Phone, AssignedRoomID, UserID)
                                            VALUES (@Name, @Email, NULL, NULL, @UserID)";

                    SqlCommand studentCmd = new SqlCommand(studentQuery, con, transaction);
                    studentCmd.Parameters.AddWithValue("@Name", newUser.Name);
                    studentCmd.Parameters.AddWithValue("@Email", newUser.Email);
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

        public static string GetUsernameById(int userId)
        {
            string username = "";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString))
            {
                string query = "SELECT Username FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userId);

                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    username = result.ToString();
                }
            }

            return username;
        }
    }

    public class RegistrationModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

