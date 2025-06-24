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

namespace Hostel_Management_System.Requests
{
    public partial class ServiceRequestForm : Form
    {
        private readonly ServiceRequestController serviceRequestController;
        private readonly StudentController studentController;
        private int currentStudentID;
        public ServiceRequestForm(int studentID)
        {
            InitializeComponent();
            serviceRequestController = new ServiceRequestController();
            studentController = new StudentController();
            currentStudentID = studentID;
            InitializeFormControls();
            LoadStudentAndRoomDetails();
        }

        private void InitializeFormControls()
        {
            requestTypeComboBox.Items.Add("Plumbing Issue");
            requestTypeComboBox.Items.Add("Electrical Issue");
            requestTypeComboBox.Items.Add("Cleaning Request");
            requestTypeComboBox.Items.Add("Furniture Repair");
            requestTypeComboBox.Items.Add("Internet/Network Issue");
            requestTypeComboBox.Items.Add("Pest Control");
            requestTypeComboBox.Items.Add("Other");
            requestTypeComboBox.SelectedIndex = 0;
        }

        private void LoadStudentAndRoomDetails()
        {
            try
            {
                StudentModel student = studentController.GetStudentById(currentStudentID);
                if (student != null)
                {
                    studentNameLabel.Text = student.Name;

                    if (student.AssignedRoomID.HasValue)
                    {
                        RoomController roomController = new RoomController();
                        RoomModel room = roomController.GetRoomById(student.AssignedRoomID.Value);
                        if (room != null)
                        {
                            roomNoLabel.Text = room.RoomNumber;
                        }
                        else
                        {
                            roomNoLabel.Text = "[No Room Assigned]";
                        }
                    }
                    else
                    {
                        roomNoLabel.Text = "[No Room Assigned]";
                    }
                }
                else
                {
                    MessageBox.Show("Student details not found. Cannot submit request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student or room details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void submitRequestBTN_Click(object sender, EventArgs e)
        {
            if (requestTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Request Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string requestType = requestTypeComboBox.SelectedItem.ToString();
            string description = descriptionRiceTextBox.Text.Trim();

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to submit this service request?",
                "Confirm Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                ServiceRequestModel newRequest = new ServiceRequestModel
                {
                    StudentID = currentStudentID,
                    RoomID = GetRoomIDFromRoomNumberLabel(),
                    Type = requestType,
                    Description = description,
                    Status = "Pending"
                };

                try
                {
                    bool success = serviceRequestController.AddServiceRequest(newRequest);

                    if (success)
                    {
                        MessageBox.Show("Service Request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit service request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int? GetRoomIDFromRoomNumberLabel()
        {
            if (int.TryParse(roomNoLabel.Text.Replace("[Room: ", "").Replace("]", "").Replace("No Room Assigned", ""), out int roomId))
            {
                return roomId;
            }
            StudentModel student = studentController.GetStudentById(currentStudentID);
            return student?.AssignedRoomID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}