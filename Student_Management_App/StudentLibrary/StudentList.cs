using System.Collections.Generic;

namespace StudentLibrary
{
    public class StudentList
    {
        private List<Student> students;
        public StudentList()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
