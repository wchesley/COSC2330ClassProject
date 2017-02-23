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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //When this link is clicked, send end-user to RegistrationForm
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Testing the tryparse for First and last name

            string rawStudentID = txtStudentID.Text;
            double conStudentID;

            if (double.TryParse(rawStudentID, out conStudentID) || txtStudentID.Text != null)
            {
                MessageBox.Show("Please re-enter your Student ID.");
            }
            else
            {

            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            string rawstudentID = txtStudentID.Text;
            int conStudentID;
               
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
        }
    }
}
