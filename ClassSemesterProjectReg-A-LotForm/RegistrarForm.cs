﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSemesterProjectReg_A_LotForm
{
    public partial class RegistrarForm : Form, IUpdateableForm
    {
        public RegistrarForm()
        {
            InitializeComponent();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            AddProfessorForm frm = new AddProfessorForm();
            frm.Show();
            this.Hide();
        }

        private void btnUpdateProfessor_Click(object sender, EventArgs e)
        {
            
            //if (Check box is checked)
            //{
                UpdateTeacherInfoForm frm = new UpdateTeacherInfoForm();
                frm.previousForm = this;
                frm.Show();
                this.Hide();
            //}
            //else
            //{
            //MessageBox.Show("Please select a professor to update.");
            //}
            

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else
            {
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Close();
                // Clear login/profile information
            }
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm frm = new AddCourseForm();
            frm.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.Show();
            this.Close();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            //if (//check box is checked)
            //{ 
            //    //delete course from database
            //}
            //else
            //{
            //    MessageBox.Show("Please select a course to remove.");
            //}
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            //if (//check box is checked)
            //{
            //    //Delete professor from ProfessorDatabase
            //}
            //else
            //{
            //    MessageBox.Show("Please select a professor to remove.");
            //}
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            string userSearch = txtBoxUserSearch.Text;

            if (cmbSearchCourse.Text == "" && txtBoxUserSearch.Text == "")
            {
                MessageBox.Show("Please pick someting to search by.");
            }
           
            else if (cmbSearchCourse.Text == "By Course Name" && txtBoxUserSearch.Text != "")
            {
                //Query over Course database by Course name
                // Display course that match what the user put in into the Datagrid. userSearch

            }
            else if (cmbSearchCourse.Text == "By Professor" && txtBoxUserSearch.Text != "")
            {
                //Query over Course database by Professor
                // Display courses that match what the user put in. userSearch
            }

            else if (cmbSearchCourse.Text == "By Course Number" && txtBoxUserSearch.Text != "")
            {
                //Query over Course database by Course Number
                // Display courses that match what the user put in userSearch
               
            }
            else if (cmbSearchCourse.Text == "Reset table")
            {
                // Show all the data in the Course database in the tblCourseData
                
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }

           
            








        }

        private void btnSearchProfessor_Click(object sender, EventArgs e)
        {
            string userSearchProfessor = txtUserSearchProfessor.Text;

            if (cmbSearchProfessor.Text == "" && userSearchProfessor == "")
            {
                MessageBox.Show("Please enter something to search by.");
            }
            else if (cmbSearchProfessor.Text == "By ID Number" && txtBoxUserSearch.Text != "")
            {
                // Query over Professor database by Professor ID
                // display professors matching the variable the user entered (userSearchProfessor)
            }
            else if (cmbSearchProfessor.Text == "By Last Name" && txtBoxUserSearch.Text != "")
            {
                // Query over professor database by LastName
                // Display professors matching the variable the user entered (userSearchProfessor)
            }
            else if (cmbSearchProfessor.Text == "Reset Table")
            {
                // Show all professors in database in the tblProfessorData.
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string userSearchStudent = txtUserSearchStudent.Text;

            if (cmbSearchProfessor.Text == "" && txtUserSearchProfessor.Text == "")
            {
                MessageBox.Show("Please enter something to seach by");
            }
            else if (cmbSearchProfessor.Text == "By ID Number" && txtUserSearchStudent.Text != "")
            {
                // Query over student database by Student ID
                // Display students matching the variable the user entered (userSearchStudent)
            }
            else if (cmbSearchStudent.Text == "By Last Name" && txtUserSearchStudent.Text != "")
            {
                // Query over student database by Student LastName
                // Display students matching the variable the user entered (userSearchStudent)
            }
            else if (cmbSearchStudent.Text == "Reset table")
            {
                // Display all the studends in the database in the tblStudentData table.
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            //if (//check box is checked)
            //{
            //    //Delete student from the database
            //}
            //else
            //{
            //    MessageBox.Show("Please select a student to remove.");
            //}
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            //if (//check box is checked)
            //{
            UpdateStudentInfoForm frm = new UpdateStudentInfoForm();
            frm.Show();
            frm.previousForm = this;
            this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Please select a student to update.");
            //}
        }

        public void PopulateForm()
        {
            throw new NotImplementedException();
        }

        private void cmbSearchStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tblCourseData_Paint(object sender, PaintEventArgs e)
        {
            // populate Course data here
        }

        private void tblProfessorData_Paint(object sender, PaintEventArgs e)
        {
            // populate professor data here
        }

        private void tblStudentData_Paint(object sender, PaintEventArgs e)
        {
            // populate student data here
        }

        private void dataGridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet3.StudentDatabase' table. You can move, or remove it, as needed.
            this.studentDatabaseTableAdapter.Fill(this.project1DataSet3.StudentDatabase);
            // TODO: This line of code loads data into the 'project1DataSet1.InstructorDatabase' table. You can move, or remove it, as needed.
            this.instructorDatabaseTableAdapter.Fill(this.project1DataSet1.InstructorDatabase);
            // TODO: This line of code loads data into the 'project1DataSet.CourseDatabase' table. You can move, or remove it, as needed.
            this.courseDatabaseTableAdapter.Fill(this.project1DataSet.CourseDatabase);

        }

        private void courseDatabaseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
