using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;

namespace Hostel_Management_System.Controller
{
    public class UtilityBillController
    {
        public List<UtilityBillModel> GetAllUtilityBills(int? roomID = null, DateTime? month = null, string status = null)
        {
            return UtilityBillModel.GetAllUtilityBills(roomID, month, status);
        }

        public UtilityBillModel GetUtilityBillById(int id)
        {
            return UtilityBillModel.GetUtilityBillById(id);
        }

        public bool AddUtilityBill(UtilityBillModel bill)
        {
            return UtilityBillModel.AddUtilityBill(bill);
        }

        public bool UpdateUtilityBill(UtilityBillModel bill)
        {
            return UtilityBillModel.UpdateUtilityBill(bill);
        }

        public bool UpdateUtilityBillStatus(int billID, string newStatus)
        {
            return UtilityBillModel.UpdateUtilityBillStatus(billID, newStatus);
        }
    }
}