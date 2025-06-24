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
    public partial class StudentListForm : Form
    {
        private readonly StudentController studentController;
        public StudentListForm()
        {
            InitializeComponent();
            studentController = new StudentController();
            LoadStudentGrid();
        }

        private void LoadStudentGrid()
        {
            try
            {
                List<StudentModel> studentList = studentController.GetAllStudents();
                studentListDataGridView.DataSource = studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStudentBTN_Click(object sender, EventArgs e)
        {
            AddEditStudentForm form = new AddEditStudentForm();
            form.ShowDialog();
            LoadStudentGrid();
        }

        private void updateStudentBTN_Click(object sender, EventArgs e)
        {
            if (studentListDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentListDataGridView.SelectedRows[0];

                if (int.TryParse(selectedRow.Cells["StudentID"].Value?.ToString(), out int studentId))
                {
                    AddEditStudentForm editForm = new AddEditStudentForm(studentId);
                    editForm.ShowDialog();

                    LoadStudentGrid();
                }
                else
                {
                    MessageBox.Show("Invalid student selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
