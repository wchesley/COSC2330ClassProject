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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            string currentName = "";
            string currentID = "";
            string currentAddress = "";
            string currentPhoneNumber = "";
            string currentPassword = "";
            string currentEmail = "";
            string currentFax = "";
            Professor newProf = new Professor();
            newProf.PopulateProfessorProfileData(out currentName, out currentAddress, out currentPhoneNumber, out currentPassword,
                out currentEmail, out currentFax, out currentID);

            lblTeacherProfileName.Text = currentName;
            lblTeacherProfileID.Text = currentID.ToString();
            lblProfileAddress.Text = currentAddress;
            lblProfilePhoneNumber.Text = currentPhoneNumber;
            lblProfileEmail.Text = currentEmail;
            lblFax.Text = currentFax;
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Go to ChangePasswordForm
            ChangePasswordForm frm = new ChangePasswordForm();
            frm.Show();
            this.Hide();
        }

        private void lnkUpdateProfileInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Go to UpdateTeacherInfoForm
            UpdateTeacherInfoForm frm = new UpdateTeacherInfoForm();
            frm.previousForm = this;
            frm.Show();
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            //Go to ScheduleForm
            ScheduleForm frm = new ScheduleForm();
            frm.Show();
            this.Hide();
        }

        private void btnRegisterForSections_Click(object sender, EventArgs e)
        {
            //Go to Rgister
            CourseRegisterForm frm = new CourseRegisterForm();
            frm.Show();
            this.Hide();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            //string currentName = "";
            //int currentID = 0;
            //string currentAddress = "";
            //string currentPhoneNumber = "";
            //string currentPassword = "";
            //string currentEmail = "";
            //string currentFax = "";
            //Professor newProf = new Professor();
            //newProf.PopulateProfessorProfileData(out currentName, out currentAddress, out currentPhoneNumber, out currentPassword,
            //    out currentEmail, out currentFax, out currentID);

            //lblTeacherProfileName.Text = currentName;
            //lblTeacherProfileID.Text = currentID.ToString();
            //lblProfileAddress.Text = currentAddress;
            //lblProfilePhoneNumber.Text = currentPhoneNumber;
            //lblProfileEmail.Text = currentEmail;
            //lblFax.Text = currentFax;
        }
    }
}
