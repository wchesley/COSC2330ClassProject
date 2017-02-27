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
            frm.Show();
            this.Hide();
        }

        private void lnkUpdateProfileInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to UpdateStudentInfoForm
            UpdateStudentInfoForm frm = new UpdateStudentInfoForm();
            frm.Show();
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            //Go to ScheduleForm
        }

        private void btnRegisterForSections_Click(object sender, EventArgs e)
        {
            //Go to Rgister
            CourseRegisterForm frm = new CourseRegisterForm();
            frm.Show();
            this.Hide();
        }
    }
}
