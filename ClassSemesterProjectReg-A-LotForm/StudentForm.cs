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
    public partial class StudentForm : Form
    {
        
        public StudentForm()
        {
            InitializeComponent();
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to ChangePasswordForm
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.PreviousForm = this;
            frm.Show();
            this.Hide();
        }

        private void lnkUpdateProfileInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to UpdateStudentInfoForm
            UpdateStudentInfoForm frm = new UpdateStudentInfoForm();
            frm.Show();
            frm.previousForm = this;
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            //Go to ScheduleForm
            ScheduleForm frm = new ScheduleForm();
            frm.previousForm = this;
            frm.Show();
            this.Hide();
        }

        private void btnRegisterForSections_Click(object sender, EventArgs e)
        {
            //Go to CourseRegister
            CourseRegisterForm frm = new CourseRegisterForm();
            frm.Show();
            this.Hide();
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

        private void lblStudentProfileID_Click(object sender, EventArgs e)
        {

        }


        //This will display the correct value.
        private void StudentForm_Shown(object sender, EventArgs e)
        {
            Student current = new Student();

            //Change the number once the student placeholder number change.
            current.CurrentStudentID = 1;

            List<string> studentDetails = current.SelectStudentRecord();
          
            lblProfileName.Text = string.Format(studentDetails[1] + " " + studentDetails[2]);
            lblStudentProfileID.Text = studentDetails[0];
            lblProfileAddress.Text = studentDetails[3];
            lblProfilePhoneNumber.Text = studentDetails[4];
            lblProfileEmail.Text = studentDetails[6];
            
            
        }
    }
}
