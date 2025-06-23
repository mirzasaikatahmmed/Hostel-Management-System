using Hostel_Management_System.Model;
using System.Configuration;
using System.Data.SqlClient;

namespace Hostel_Management_System.Controller
{
    public class UserController
    {
        private string cs = ConfigurationManager.ConnectionStrings["dhcs"].ConnectionString;

        public string GetUsernameById(int userId)
        {
            string username = "";

            using (SqlConnection con = new SqlConnection(cs))
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
}
