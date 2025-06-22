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
    public partial class StudentDashboard : Form
    {
        private int currentUserId;
        public StudentDashboard()
        {
            InitializeComponent();
        }

        public StudentDashboard(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
    }
}
