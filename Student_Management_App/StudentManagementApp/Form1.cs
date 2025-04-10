using StudentLibrary;
using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        private StudentList studentList;

        public Form1()
        {
            InitializeComponent();
            studentList = new StudentList();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Surname", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", -2, HorizontalAlignment.Left);
        }

        ////////// VERİ GİRME //////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Department = txtDepartment.Text
            };

            studentList.AddStudent(student);
            RefreshStudentList();
        }
        ////////// LİSTEYE EKLEME //////////////////
        private void RefreshStudentList()
        {
            listView1.Items.Clear();
            foreach (var student in studentList.GetAllStudents())
            {
                var item = new ListViewItem(new[] { student.Id.ToString(), student.Name, student.Surname, student.Department });
                listView1.Items.Add(item);
            }
        }
    }
}
