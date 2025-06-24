using Hostel_Management_System.Controller;
using Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Rooms
{
    public partial class AssignRoomForm : Form
    {
        private readonly RoomAssignmentController roomAssignmentController;
        private readonly StudentController studentController;
        private readonly RoomController roomController;

        private StudentModel selectedStudent;
        private RoomModel selectedRoom;
        public AssignRoomForm()
        {
            InitializeComponent();
            roomAssignmentController = new RoomAssignmentController();
            studentController = new StudentController();
            roomController = new RoomController();
            InitializeFormControls();
        }

        private void InitializeFormControls()
        {
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            PopulateStudentComboBox();
            PopulateRoomComboBox();

            studentNameComboBox.SelectedIndexChanged += studentNameComboBox_SelectedIndexChanged;
            roomComboBox.SelectedIndexChanged += roomComboBox_SelectedIndexChanged;
        }

        private void PopulateStudentComboBox()
        {
            try
            {
                List<StudentModel> students = studentController.GetAllStudents();

                studentNameComboBox.DataSource = students;
                studentNameComboBox.DisplayMember = "Name";
                studentNameComboBox.ValueMember = "StudentID";
                studentNameComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRoomComboBox()
        {
            try
            {
                List<RoomModel> rooms = roomController.GetAllRooms();
                rooms = rooms.Where(r => r.Status == "Available").ToList();

                roomComboBox.DataSource = rooms;
                roomComboBox.DisplayMember = "RoomNumber";
                roomComboBox.ValueMember = "RoomID";
                roomComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load room list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentNameComboBox.SelectedItem is StudentModel student)
            {
                selectedStudent = student;
            }
            else
            {
                selectedStudent = null;
            }
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomComboBox.SelectedItem is RoomModel room)
            {
                selectedRoom = room;
            }
            else
            {
                selectedRoom = null;
            }
        }

        private void assignRoomBTN_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = startDateTimePicker.Value.Date;
            DateTime? endDate = endDateTimePicker.Checked ? (DateTime?)endDateTimePicker.Value.Date : null;

            if (endDate.HasValue && startDate > endDate.Value)
            {
                MessageBox.Show("End Date cannot be before Start Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RoomAssignmentModel newAssignment = new RoomAssignmentModel
            {
                StudentID = selectedStudent.StudentID,
                RoomID = selectedRoom.RoomID,
                StartDate = startDate,
                EndDate = endDate
            };

            try
            {
                bool success = roomAssignmentController.AssignRoomToStudent(newAssignment);

                if (success)
                {
                    MessageBox.Show($"Room {selectedRoom.RoomNumber} assigned to {selectedStudent.Name} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to assign room. Please ensure the room is available and student is not already assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred during assignment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
