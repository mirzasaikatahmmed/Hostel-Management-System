using Hostel_Management_System.Model;
using Hostel_Management_System.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Hostel_Management_System.Controller
{
    public class UserController
    {
        public string FetchUsername(int userId)
        {
            return UserModel.GetUsernameById(userId);
        }
    }
}
