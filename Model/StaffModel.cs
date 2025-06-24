using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Model
{
    internal class StaffModel
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<StaffModel> GetAllStaff()
        {
            List<StaffModel> staffList = new List<StaffModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        s.StaffID, 
                        s.Name, 
                        s.Role, 
                        s.Phone, 
                        s.UserID,
                        u.Username,
                        u.Email,
                        u.Password
                    FROM Staff s
                    JOIN Users u ON s.UserID = u.UserID";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    staffList.Add(new StaffModel
                    {
                        StaffID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Role = reader.GetString(2),
                        Phone = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        UserID = reader.GetInt32(4),
                        Username = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        Password = reader.IsDBNull(7) ? "" : reader.GetString(7)
                    });
                }
            }

            return staffList;
        }

        public static StaffModel GetStaffById(int id)
        {
            StaffModel staff = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        s.StaffID, 
                        s.Name, 
                        s.Role, 
                        s.Phone, 
                        s.UserID,
                        u.Username,
                        u.Email,
                        u.Password
                    FROM Staff s
                    JOIN Users u ON s.UserID = u.UserID
                    WHERE s.StaffID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    staff = new StaffModel
                    {
                        StaffID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Role = reader.GetString(2),
                        Phone = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        UserID = reader.GetInt32(4),
                        Username = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        Email = reader.IsDBNull(6) ? "" : reader.GetString(6),
                        Password = reader.IsDBNull(7) ? "" : reader.GetString(7)
                    };
                }
            }

            return staff;
        }

        public static bool AddStaff(StaffModel staff)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string userQuery = @"
                        INSERT INTO Users (Username, Email, Password, Role) 
                        VALUES (@Username, @Email, @Password, 'Staff');
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand userCmd = new SqlCommand(userQuery, con, transaction);
                    userCmd.Parameters.AddWithValue("@Username", staff.Name);
                    userCmd.Parameters.AddWithValue("@Email", staff.Email);
                    userCmd.Parameters.AddWithValue("@Password", staff.Password);

                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    string staffQuery = @"
                        INSERT INTO Staff (Name, Role, Phone, UserID) 
                        VALUES (@Name, @StaffRole, @Phone, @UserID)";

                    SqlCommand staffCmd = new SqlCommand(staffQuery, con, transaction);
                    staffCmd.Parameters.AddWithValue("@Name", staff.Name);
                    staffCmd.Parameters.AddWithValue("@StaffRole", staff.Role);
                    staffCmd.Parameters.AddWithValue("@Phone", staff.Phone ?? (object)DBNull.Value);
                    staffCmd.Parameters.AddWithValue("@UserID", userId);

                    int rowsAffected = staffCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding staff: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public static bool UpdateStaff(StaffModel staff)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string updateUserQuery = @"
                        UPDATE Users 
                        SET Username = @Username, Email = @Email, Password = @Password 
                        WHERE UserID = @UserID";

                    SqlCommand userCmd = new SqlCommand(updateUserQuery, con, transaction);
                    userCmd.Parameters.AddWithValue("@Username", staff.Name);
                    userCmd.Parameters.AddWithValue("@Email", staff.Email);
                    userCmd.Parameters.AddWithValue("@Password", staff.Password);
                    userCmd.Parameters.AddWithValue("@UserID", staff.UserID);
                    userCmd.ExecuteNonQuery();

                    string updateStaffQuery = @"
                        UPDATE Staff 
                        SET Name = @Name, Role = @StaffRole, Phone = @Phone 
                        WHERE StaffID = @StaffID";

                    SqlCommand staffCmd = new SqlCommand(updateStaffQuery, con, transaction);
                    staffCmd.Parameters.AddWithValue("@Name", staff.Name);
                    staffCmd.Parameters.AddWithValue("@StaffRole", staff.Role);
                    staffCmd.Parameters.AddWithValue("@Phone", staff.Phone ?? (object)DBNull.Value);
                    staffCmd.Parameters.AddWithValue("@StaffID", staff.StaffID);

                    int rowsAffected = staffCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating staff: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
