using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COSC2330ClassProject;

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
            //string rawCourseName;
            string UserInput= txtBoxUserSearch.Text;

            if (cmbSearchCourse.Text == "" && txtBoxUserSearch.Text == "")
            {
                MessageBox.Show("Please pick someting to search by.");
            }

            else if (cmbSearchCourse.Text == "By Course Name" && txtBoxUserSearch.Text != "")
            {
                Registrar Reg = new Registrar();
                Reg.searchCourseName(UserInput);
                //Show Results

            }
            else if (cmbSearchCourse.Text == "By Professor" && txtBoxUserSearch.Text != "")
            {
                Registrar Reg = new Registrar();
                Reg.searchCourseProfessor(UserInput);
                //txtBoxUserSearch.Text.Substring(0, 3);
                //Show Results
            }

            else if (cmbSearchCourse.Text == "By Course Number" && txtBoxUserSearch.Text != "")
            {
                
                Registrar Reg = new Registrar();
                Reg.searchCourseNumber(UserInput);
                //Show results
            }
            else if (cmbSearchCourse.Text == "Reset table")
            {
                // Show all the data in the Course database in the tblCourseData

            }
            else
            {
                MessageBox.Show("Enter atleast 4 characters to search by.");
            }











        }

        private void btnSearchProfessor_Click(object sender, EventArgs e)
        {
            string UserInput = txtBoxUserSearch.Text;
            string userSearchProfessor = txtUserSearchProfessor.Text;

            if (cmbSearchProfessor.Text == "" && userSearchProfessor == "")
            {
                MessageBox.Show("Please enter something to search by.");
            }
            else if (cmbSearchProfessor.Text == "By ID Number" && txtBoxUserSearch.Text != "")
            {
                Registrar Reg = new Registrar();
                Reg.searchProfessorIDNumber(UserInput);
                // Show in data grid
            }
            else if (cmbSearchProfessor.Text == "By Last Name" && txtBoxUserSearch.Text != "")
            {
                
            }
            else if (cmbSearchProfessor.Text == "Reset Table")
            {
                // Reset table
            }
            else
            {
                MessageBox.Show("Enter something to search by.");
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string UserInput = txtUserSearchStudent.Text;

            if (cmbSearchProfessor.Text == "" && txtUserSearchProfessor.Text == "")
            {
                MessageBox.Show("Please enter something to seach by");
            }
            else if (cmbSearchProfessor.Text == "By ID Number" && txtUserSearchStudent.Text != "")
            {
                Registrar Reg = new Registrar();
                Reg.searchStudentIDNumber(UserInput);
                //Show in datagrid
            }
            else if (cmbSearchStudent.Text == "By Last Name" && txtUserSearchStudent.Text != "")
            {
                Registrar Reg = new Registrar();
                Reg.searchLast(UserInput);
                //Show in datagrid
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

        //private void tblCourseData_Paint(object sender, PaintEventArgs e)
        //{
        //    // populate Course data here
        //}

        //private void tblProfessorData_Paint(object sender, PaintEventArgs e)
        //{
        //    // populate professor data here
        //}

        //private void tblStudentData_Paint(object sender, PaintEventArgs e)
        //{
        //    // populate student data here
        //}

        
    }
}
