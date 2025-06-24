using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controller
{
    internal class StaffController
    {
        public List<StaffModel> GetAllStaff()
        {
            return StaffModel.GetAllStaff();
        }
        public StaffModel GetStaffById(int id)
        {
            return StaffModel.GetStaffById(id);
        }
        public bool AddStaff(StaffModel staff)
        {
            return StaffModel.AddStaff(staff);
        }
        public bool UpdateStaff(StaffModel staff)
        {
            return StaffModel.UpdateStaff(staff);
        }
    }
}
