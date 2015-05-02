using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefinedListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> aStudentlist = new List<Student>(); 
        private void showAllButton_Click(object sender, EventArgs e)
        {
            string studentInfo = "RegNo.\t Name\n";
            foreach (Student student in aStudentlist)
            {
                studentInfo += student.regNo + " " +student.firstName+ " " +student.lastName+"\n";


            }
            MessageBox.Show(studentInfo);

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student  aStudent=new Student();
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            aStudent.regNo = regNoTextBox.Text;
            aStudentlist.Add(aStudent);
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            regNoTextBox.Clear();
            MessageBox.Show("Saved");



        }
    }
}
