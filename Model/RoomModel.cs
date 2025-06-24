using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Hostel_Management_System.Model
{
    public class RoomModel
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<RoomModel> GetAllRooms()
        {
            List<RoomModel> rooms = new List<RoomModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT RoomID, RoomNumber, Capacity, Status FROM Rooms";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rooms.Add(new RoomModel
                    {
                        RoomID = reader.GetInt32(0),
                        RoomNumber = reader.GetString(1),
                        Capacity = reader.GetInt32(2),
                        Status = reader.GetString(3)
                    });
                }
            }

            return rooms;
        }

        public static RoomModel GetRoomById(int id)
        {
            RoomModel room = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT RoomID, RoomNumber, Capacity, Status FROM Rooms WHERE RoomID = @RoomID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    room = new RoomModel
                    {
                        RoomID = reader.GetInt32(0),
                        RoomNumber = reader.GetString(1),
                        Capacity = reader.GetInt32(2),
                        Status = reader.GetString(3)
                    };
                }
            }

            return room;
        }

        public static bool AddRoom(RoomModel room)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    INSERT INTO Rooms (RoomNumber, Capacity, Status) 
                    VALUES (@RoomNumber, @Capacity, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                cmd.Parameters.AddWithValue("@Status", room.Status);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding room: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool UpdateRoom(RoomModel room)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    UPDATE Rooms 
                    SET 
                        RoomNumber = @RoomNumber, 
                        Capacity = @Capacity, 
                        Status = @Status 
                    WHERE RoomID = @RoomID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                cmd.Parameters.AddWithValue("@Status", room.Status);
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating room: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool DeleteRoom(int roomID)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", roomID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting room: {ex.Message}");
                    return false;
                }
            }
        }
    }
}