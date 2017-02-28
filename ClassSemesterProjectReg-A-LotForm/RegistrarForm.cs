using System;
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
    public partial class RegistrarForm : Form
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
            //AddTeacherForm frm = new AddTeacherForm();
            UpdateTeacherInfoForm frm = new UpdateTeacherInfoForm();
            frm.previousForm = this;
            frm.Show();
            this.Hide();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            //Check for checked course, if course is checked, delete it from the database
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
                // Display course that match what the user put in. userSearch

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
                // Show all the data in the Course database
                
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }

           
            








        }

        private void btnSearchProfessor_Click(object sender, EventArgs e)
        {
            string userSearch = txtBoxUserSearch.Text;

            if (cmbSearchProfessor.Text == "" && userSearch == "")
            {
                MessageBox.Show("Please Enter something to search by.");
            }
            else if (cmbSearchProfessor.Text == "By ID Number" && txtBoxUserSearch.Text != "")
            {
                // Query over Professor database by Professor ID
                // display professors matching the ID number the user entered (userSearch)
            }
            else if (cmbSearchProfessor.Text == "By Last Name" && txtBoxUserSearch.Text != "")
            {
                // Query over professor database by LastName
                // Display professors matching the LastName the user entered (userSearch)
            }
            else if (cmbSearchProfessor.Text == "Reset Table")
            {
                // Show all professors in database.
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
