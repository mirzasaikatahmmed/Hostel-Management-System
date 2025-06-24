using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Hostel_Management_System.Model
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? AssignedRoomID { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<StudentModel> GetAllStudents()
        {
            List<StudentModel> students = new List<StudentModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT StudentID, Name, Email, Phone, AssignedRoomID FROM Students";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new StudentModel
                    {
                        StudentID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Phone = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        AssignedRoomID = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4)
                    });
                }
            }

            return students;
        }

        public static StudentModel GetStudentById(int id)
        {
            StudentModel student = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT s.StudentID, s.Name, s.Email, s.Phone, u.Password, u.UserID 
                                 FROM Students s 
                                 JOIN Users u ON s.UserID = u.UserID 
                                 WHERE s.StudentID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    student = new StudentModel
                    {
                        StudentID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Phone = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Password = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        UserID = reader.GetInt32(5)
                    };
                }
            }

            return student;
        }

        public static bool AddStudent(StudentModel student)
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
                    userCmd.Parameters.AddWithValue("@Username", student.Name);
                    userCmd.Parameters.AddWithValue("@Email", student.Email);
                    userCmd.Parameters.AddWithValue("@Password", student.Password);
                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    string studentQuery = @"INSERT INTO Students (Name, Email, Phone, AssignedRoomID, UserID) 
                                            VALUES (@Name, @Email, @Phone, NULL, @UserID)";

                    SqlCommand studentCmd = new SqlCommand(studentQuery, con, transaction);
                    studentCmd.Parameters.AddWithValue("@Name", student.Name);
                    studentCmd.Parameters.AddWithValue("@Email", student.Email);
                    studentCmd.Parameters.AddWithValue("@Phone", student.Phone);
                    studentCmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = studentCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        transaction.Commit();
                        return true;
                    }

                    transaction.Rollback();
                    return false;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public static bool UpdateStudent(StudentModel student)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string updateUserQuery = @"UPDATE Users 
                                               SET Username = @Username, Email = @Email, Password = @Password 
                                               WHERE UserID = @UserID";

                    SqlCommand userCmd = new SqlCommand(updateUserQuery, con, transaction);
                    userCmd.Parameters.AddWithValue("@Username", student.Name);
                    userCmd.Parameters.AddWithValue("@Email", student.Email);
                    userCmd.Parameters.AddWithValue("@Password", student.Password);
                    userCmd.Parameters.AddWithValue("@UserID", student.UserID);
                    userCmd.ExecuteNonQuery();

                    string updateStudentQuery = @"UPDATE Students 
                                                  SET Name = @Name, Email = @Email, Phone = @Phone 
                                                  WHERE StudentID = @StudentID";

                    SqlCommand studentCmd = new SqlCommand(updateStudentQuery, con, transaction);
                    studentCmd.Parameters.AddWithValue("@Name", student.Name);
                    studentCmd.Parameters.AddWithValue("@Email", student.Email);
                    studentCmd.Parameters.AddWithValue("@Phone", student.Phone);
                    studentCmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    studentCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
