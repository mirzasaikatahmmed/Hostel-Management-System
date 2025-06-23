using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hostel_Management_System.Controller
{
    public class StudentController
    {
        private readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public List<StudentModel> GetAllStudents()
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

        public StudentModel GetStudentById(int id)
        {
            StudentModel student = null;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT StudentID, Name, Email, Phone FROM Students WHERE StudentID = @id";
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
                        Email = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Password = reader.IsDBNull(4) ? "" : reader.GetString(4)
                    };
                }
            }
            return student;
        }

        public bool AddStudent(StudentModel student)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"INSERT INTO Students (Name, Email, Phone, AssignedRoomID, UserID)
                         VALUES (@Name, @Email, @Phone, NULL, NULL)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Phone", student.Phone);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStudent(StudentModel student)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"UPDATE Students SET Name = @Name, Email = @Email, Phone = @Phone
                         WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Phone", student.Phone);
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
