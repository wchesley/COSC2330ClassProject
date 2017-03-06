using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COSC2330ClassProject; // added to access dll. 

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

            string rawID = txtID.Text;
            int conID;
            AddUser loginCheck = new AddUser();
            
            if (int.TryParse(rawID, out conID) && txtID.Text != "") // if its a number, and not blank...
            {
                if (txtPassword.Text != "") // if the password field is not empty
                {
                   if( loginCheck.VerifyLogin((string)txtID.Text, (string)txtPassword.Text) == true)  // checking userID and password against DB. needs testing, espically with paswords and numbers in passwords.
                    {

                        MessageBox.Show("Retreiving your data...");
                        this.Hide();
                       
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
            
        }

        

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //string password = newUser.HashPass(txtPassword.Text); // hashed password after user enteres it. 
        }



        // ************* THESE BUTTONS ARE TO TEST THE STUDENT, REGISTRAR, AND TEACHER FORMS, THEY WILL BE DELETED ONCE WE IMPLIMENT THE LOGIN FUNCTION*******

        private void btnTestStudentForm_Click(object sender, EventArgs e) // DELETE THIS LATER
        {
            StudentForm frm = new StudentForm();
            frm.Show();
            this.Hide();

        }

        private void btnTestTeacherForm_Click(object sender, EventArgs e) // DELETE THIS LATER
        {
            TeacherForm frm = new TeacherForm();
            frm.Show();
            this.Hide();
        }

        private void btnTestRegistrarForm_Click(object sender, EventArgs e) // DELETE THIS LATER
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }
    }
}
