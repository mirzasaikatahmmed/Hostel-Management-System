using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Hostel_Management_System.Model
{
    public class ServiceRequestModel
    {
        public int RequestID { get; set; }
        public int StudentID { get; set; }
        public int? RoomID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string StudentName { get; set; }
        public string RoomNumber { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<ServiceRequestModel> GetAllServiceRequests()
        {
            List<ServiceRequestModel> requests = new List<ServiceRequestModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        sr.RequestID, 
                        sr.StudentID, 
                        sr.RoomID, 
                        sr.Type, 
                        sr.Description, 
                        sr.Status,
                        s.Name AS StudentName,
                        r.RoomNumber
                    FROM ServiceRequests sr
                    JOIN Students s ON sr.StudentID = s.StudentID
                    LEFT JOIN Rooms r ON sr.RoomID = r.RoomID";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    requests.Add(new ServiceRequestModel
                    {
                        RequestID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        RoomID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        Type = reader.GetString(3),
                        Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Status = reader.GetString(5),
                        StudentName = reader.GetString(6),
                        RoomNumber = reader.IsDBNull(7) ? "N/A" : reader.GetString(7)
                    });
                }
            }

            return requests;
        }

        public static ServiceRequestModel GetServiceRequestById(int id)
        {
            ServiceRequestModel request = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    SELECT 
                        sr.RequestID, 
                        sr.StudentID, 
                        sr.RoomID, 
                        sr.Type, 
                        sr.Description, 
                        sr.Status,
                        s.Name AS StudentName,
                        r.RoomNumber
                    FROM ServiceRequests sr
                    JOIN Students s ON sr.StudentID = s.StudentID
                    LEFT JOIN Rooms r ON sr.RoomID = r.RoomID
                    WHERE sr.RequestID = @RequestID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RequestID", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    request = new ServiceRequestModel
                    {
                        RequestID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        RoomID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                        Type = reader.GetString(3),
                        Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        Status = reader.GetString(5),
                        StudentName = reader.GetString(6),
                        RoomNumber = reader.IsDBNull(7) ? "N/A" : reader.GetString(7)
                    };
                }
            }

            return request;
        }

        public static bool AddServiceRequest(ServiceRequestModel request)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    INSERT INTO ServiceRequests (StudentID, RoomID, Type, Description, Status) 
                    VALUES (@StudentID, @RoomID, @Type, @Description, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", request.StudentID);
                cmd.Parameters.AddWithValue("@RoomID", request.RoomID.HasValue ? (object)request.RoomID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Type", request.Type);
                cmd.Parameters.AddWithValue("@Description", request.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", "Pending");

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding service request: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool UpdateServiceRequest(ServiceRequestModel request)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    UPDATE ServiceRequests 
                    SET 
                        StudentID = @StudentID, 
                        RoomID = @RoomID, 
                        Type = @Type, 
                        Description = @Description, 
                        Status = @Status 
                    WHERE RequestID = @RequestID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentID", request.StudentID);
                cmd.Parameters.AddWithValue("@RoomID", request.RoomID.HasValue ? (object)request.RoomID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Type", request.Type);
                cmd.Parameters.AddWithValue("@Description", request.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", request.Status);
                cmd.Parameters.AddWithValue("@RequestID", request.RequestID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating service request: {ex.Message}");
                    return false;
                }
            }
        }
    }
}