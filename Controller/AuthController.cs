using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hostel_Management_System.Controller
{
    public class AuthController
    {
        public UserModel Login(string email, string password)
        {
            return UserModel.LoginUser(email, password);
        }

        public bool Register(RegistrationModel user, out string errorMessage)
        {
            return UserModel.RegisterUser(user, out errorMessage);
        }
    }
}