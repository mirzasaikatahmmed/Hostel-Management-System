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

namespace Hostel_Management_System.Students
{
    public partial class AddEditStudentForm : Form
    {
        private readonly StudentController studentController;
        private readonly int? studentId;
        private bool isUpdateMode = false;
        public AddEditStudentForm()
        {
            InitializeComponent();
            studentController = new StudentController();
        }

        public AddEditStudentForm(int studentId) : this()
        {
            this.studentId = studentId;
            isUpdateMode = true;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            var student = studentController.GetStudentById(studentId.Value);
            if (student != null)
            {
                nameTextBox.Text = student.Name;
                contactNoTextBox.Text = student.Phone;
                emailTextBox.Text = student.Email;
                passwordTextBox.Text = student.Password;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateStudentBTN_Click(object sender, EventArgs e)
        {
            StudentModel model = new StudentModel
            {
                StudentID = studentId ?? 0,
                Name = nameTextBox.Text.Trim(),
                Phone = contactNoTextBox.Text.Trim(),
                Email = emailTextBox.Text.Trim(),
                Password = passwordTextBox.Text.Trim()
            };

            bool success;
            if (isUpdateMode)
                success = studentController.UpdateStudent(model);
            else
                success = studentController.AddStudent(model);

            if (success)
            {
                MessageBox.Show(isUpdateMode ? "Student updated!" : "Student added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Operation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
