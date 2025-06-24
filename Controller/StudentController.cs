using Hostel_Management_System.Model;
using System.Collections.Generic;

namespace Hostel_Management_System.Controller
{
    public class StudentController
    {
        public List<StudentModel> GetAllStudents()
        {
            return StudentModel.GetAllStudents();
        }

        public StudentModel GetStudentById(int id)
        {
            return StudentModel.GetStudentById(id);
        }

        public bool AddStudent(StudentModel student)
        {
            return StudentModel.AddStudent(student);
        }

        public bool UpdateStudent(StudentModel student)
        {
            return StudentModel.UpdateStudent(student);
        }
    }
}
