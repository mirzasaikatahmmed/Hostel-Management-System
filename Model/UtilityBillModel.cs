using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Hostel_Management_System.Model
{
    public class UtilityBillModel
    {
        public int BillID { get; set; }
        public int RoomID { get; set; }
        public DateTime Month { get; set; }
        public decimal Electricity { get; set; }
        public decimal Water { get; set; }
        public decimal Gas { get; set; }
        public string Status { get; set; }

        private static readonly string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public static List<UtilityBillModel> GetAllUtilityBills(int? roomID = null, DateTime? month = null, string status = null)
        {
            List<UtilityBillModel> bills = new List<UtilityBillModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("SELECT BillID, RoomID, Month, Electricity, Water, Gas, Status FROM UtilityBills WHERE 1=1");

                if (roomID.HasValue)
                {
                    queryBuilder.Append(" AND RoomID = @RoomID");
                }
                if (month.HasValue)
                {
                    queryBuilder.Append(" AND YEAR(Month) = @Year AND MONTH(Month) = @Month");
                }
                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    queryBuilder.Append(" AND Status = @Status");
                }

                SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), con);

                if (roomID.HasValue)
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomID.Value);
                }
                if (month.HasValue)
                {
                    cmd.Parameters.AddWithValue("@Year", month.Value.Year);
                    cmd.Parameters.AddWithValue("@Month", month.Value.Month);
                }
                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                }

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bills.Add(new UtilityBillModel
                    {
                        BillID = reader.GetInt32(0),
                        RoomID = reader.GetInt32(1),
                        Month = reader.GetDateTime(2),
                        Electricity = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                        Water = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                        Gas = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                        Status = reader.GetString(6)
                    });
                }
            }

            return bills;
        }

        public static UtilityBillModel GetUtilityBillById(int id)
        {
            UtilityBillModel bill = null;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT BillID, RoomID, Month, Electricity, Water, Gas, Status FROM UtilityBills WHERE BillID = @BillID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BillID", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bill = new UtilityBillModel
                    {
                        BillID = reader.GetInt32(0),
                        RoomID = reader.GetInt32(1),
                        Month = reader.GetDateTime(2),
                        Electricity = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                        Water = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                        Gas = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                        Status = reader.GetString(6)
                    };
                }
            }

            return bill;
        }

        public static bool AddUtilityBill(UtilityBillModel bill)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    INSERT INTO UtilityBills (RoomID, Month, Electricity, Water, Gas, Status) 
                    VALUES (@RoomID, @Month, @Electricity, @Water, @Gas, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", bill.RoomID);
                cmd.Parameters.AddWithValue("@Month", bill.Month.Date);
                cmd.Parameters.AddWithValue("@Electricity", bill.Electricity);
                cmd.Parameters.AddWithValue("@Water", bill.Water);
                cmd.Parameters.AddWithValue("@Gas", bill.Gas);
                cmd.Parameters.AddWithValue("@Status", bill.Status);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding utility bill: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool UpdateUtilityBill(UtilityBillModel bill)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    UPDATE UtilityBills 
                    SET 
                        RoomID = @RoomID, 
                        Month = @Month, 
                        Electricity = @Electricity, 
                        Water = @Water, 
                        Gas = @Gas, 
                        Status = @Status 
                    WHERE BillID = @BillID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", bill.RoomID);
                cmd.Parameters.AddWithValue("@Month", bill.Month.Date);
                cmd.Parameters.AddWithValue("@Electricity", bill.Electricity);
                cmd.Parameters.AddWithValue("@Water", bill.Water);
                cmd.Parameters.AddWithValue("@Gas", bill.Gas);
                cmd.Parameters.AddWithValue("@Status", bill.Status);
                cmd.Parameters.AddWithValue("@BillID", bill.BillID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating utility bill: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool UpdateUtilityBillStatus(int billID, string newStatus)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE UtilityBills SET Status = @NewStatus WHERE BillID = @BillID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                cmd.Parameters.AddWithValue("@BillID", billID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating utility bill status: {ex.Message}");
                    return false;
                }
            }
        }
    }
}