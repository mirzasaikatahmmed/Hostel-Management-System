using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Hostel_Management_System.Model
{
    public class RoomAssignmentModel
    {
        public int AssignmentID { get; set; }
        public int RoomID { get; set; }
        public int StudentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StudentName { get; set; }
        public string RoomNumber { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<RoomAssignmentModel> GetAllRoomAssignments()
        {
            List<RoomAssignmentModel> assignments = new List<RoomAssignmentModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        ra.AssignmentID, 
                        ra.RoomID, 
                        ra.StudentID, 
                        ra.StartDate, 
                        ra.EndDate,
                        s.Name AS StudentName,
                        r.RoomNumber
                    FROM RoomAssignments ra
                    JOIN Students s ON ra.StudentID = s.StudentID
                    JOIN Rooms r ON ra.RoomID = r.RoomID";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    assignments.Add(new RoomAssignmentModel
                    {
                        AssignmentID = reader.GetInt32(0),
                        RoomID = reader.GetInt32(1),
                        StudentID = reader.GetInt32(2),
                        StartDate = reader.GetDateTime(3),
                        EndDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        StudentName = reader.GetString(5),
                        RoomNumber = reader.GetString(6)
                    });
                }
            }

            return assignments;
        }

        public static RoomAssignmentModel GetRoomAssignmentById(int id)
        {
            RoomAssignmentModel assignment = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        ra.AssignmentID, 
                        ra.RoomID, 
                        ra.StudentID, 
                        ra.StartDate, 
                        ra.EndDate,
                        s.Name AS StudentName,
                        r.RoomNumber
                    FROM RoomAssignments ra
                    JOIN Students s ON ra.StudentID = s.StudentID
                    JOIN Rooms r ON ra.RoomID = r.RoomID
                    WHERE ra.AssignmentID = @AssignmentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AssignmentID", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    assignment = new RoomAssignmentModel
                    {
                        AssignmentID = reader.GetInt32(0),
                        RoomID = reader.GetInt32(1),
                        StudentID = reader.GetInt32(2),
                        StartDate = reader.GetDateTime(3),
                        EndDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                        StudentName = reader.GetString(5),
                        RoomNumber = reader.GetString(6)
                    };
                }
            }

            return assignment;
        }

        public static bool AssignRoomToStudent(RoomAssignmentModel assignment)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string insertAssignmentQuery = @"
                        INSERT INTO RoomAssignments (RoomID, StudentID, StartDate, EndDate) 
                        VALUES (@RoomID, @StudentID, @StartDate, @EndDate)";

                    SqlCommand insertAssignmentCmd = new SqlCommand(insertAssignmentQuery, con, transaction);
                    insertAssignmentCmd.Parameters.AddWithValue("@RoomID", assignment.RoomID);
                    insertAssignmentCmd.Parameters.AddWithValue("@StudentID", assignment.StudentID);
                    insertAssignmentCmd.Parameters.AddWithValue("@StartDate", assignment.StartDate.Date);
                    insertAssignmentCmd.Parameters.AddWithValue("@EndDate", assignment.EndDate.HasValue ? (object)assignment.EndDate.Value.Date : DBNull.Value);
                    insertAssignmentCmd.ExecuteNonQuery();

                    string updateStudentQuery = "UPDATE Students SET AssignedRoomID = @RoomID WHERE StudentID = @StudentID";
                    SqlCommand updateStudentCmd = new SqlCommand(updateStudentQuery, con, transaction);
                    updateStudentCmd.Parameters.AddWithValue("@RoomID", assignment.RoomID);
                    updateStudentCmd.Parameters.AddWithValue("@StudentID", assignment.StudentID);
                    updateStudentCmd.ExecuteNonQuery();

                    string updateRoomStatusQuery = "UPDATE Rooms SET Status = 'Occupied' WHERE RoomID = @RoomID AND Status = 'Available'";
                    SqlCommand updateRoomStatusCmd = new SqlCommand(updateRoomStatusQuery, con, transaction);
                    updateRoomStatusCmd.Parameters.AddWithValue("@RoomID", assignment.RoomID);
                    updateRoomStatusCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error assigning room: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public static bool UpdateRoomAssignment(RoomAssignmentModel assignment)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    UPDATE RoomAssignments 
                    SET 
                        RoomID = @RoomID, 
                        StudentID = @StudentID, 
                        StartDate = @StartDate, 
                        EndDate = @EndDate 
                    WHERE AssignmentID = @AssignmentID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", assignment.RoomID);
                cmd.Parameters.AddWithValue("@StudentID", assignment.StudentID);
                cmd.Parameters.AddWithValue("@StartDate", assignment.StartDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", assignment.EndDate.HasValue ? (object)assignment.EndDate.Value.Date : DBNull.Value);
                cmd.Parameters.AddWithValue("@AssignmentID", assignment.AssignmentID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating room assignment: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool DeleteRoomAssignment(int assignmentID, int studentID, int roomID)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string updateStudentQuery = "UPDATE Students SET AssignedRoomID = NULL WHERE StudentID = @StudentID";
                    SqlCommand updateStudentCmd = new SqlCommand(updateStudentQuery, con, transaction);
                    updateStudentCmd.Parameters.AddWithValue("@StudentID", studentID);
                    updateStudentCmd.ExecuteNonQuery();

                    string deleteAssignmentQuery = "DELETE FROM RoomAssignments WHERE AssignmentID = @AssignmentID";
                    SqlCommand deleteAssignmentCmd = new SqlCommand(deleteAssignmentQuery, con, transaction);
                    deleteAssignmentCmd.Parameters.AddWithValue("@AssignmentID", assignmentID);
                    deleteAssignmentCmd.ExecuteNonQuery();

                    string checkRoomOccupancyQuery = "SELECT COUNT(*) FROM Students WHERE AssignedRoomID = @RoomID";
                    SqlCommand checkRoomOccupancyCmd = new SqlCommand(checkRoomOccupancyQuery, con, transaction);
                    checkRoomOccupancyCmd.Parameters.AddWithValue("@RoomID", roomID);
                    int currentOccupants = (int)checkRoomOccupancyCmd.ExecuteScalar();

                    if (currentOccupants == 0)
                    {
                        string updateRoomStatusQuery = "UPDATE Rooms SET Status = 'Available' WHERE RoomID = @RoomID";
                        SqlCommand updateRoomStatusCmd = new SqlCommand(updateRoomStatusQuery, con, transaction);
                        updateRoomStatusCmd.Parameters.AddWithValue("@RoomID", roomID);
                        updateRoomStatusCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting room assignment: {ex.Message}");
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}