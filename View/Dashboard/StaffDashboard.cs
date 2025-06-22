using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Dashboard
{
    public partial class StaffDashboard : Form
    {
        private int currentUserId;  
        public StaffDashboard()
        {
            InitializeComponent();
        }

        public StaffDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
    }
}
