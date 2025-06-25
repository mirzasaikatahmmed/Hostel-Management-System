using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.View.Rooms
{
    public partial class MyRoom : Form
    {
        public MyRoom()
        {
            InitializeComponent();
        }
        public MyRoom(int studentID)
        {
            InitializeComponent();
            LoadStudentDetails(studentID);
            LoadRoomDetails(studentID);
        }
        public void LoadStudentDetails(int studentID)
        {
        }
        public void LoadRoomDetails(int studentID)
        {
        }
    }
}
