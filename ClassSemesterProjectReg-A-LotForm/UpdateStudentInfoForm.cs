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
    public partial class UpdateStudentInfoForm : Form
    {
        public Form previousForm { get; set; }
        public UpdateStudentInfoForm()
        {
            InitializeComponent();
        }

        Student newStud = new Student(); 

        private void btnDone_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void btnUpdateFirstName_Click(object sender, EventArgs e)  // The user updates their First name
        {
            //UpdateFirstName
            string newFistName = txtUpdateFirstName.Text;
            double conFirstName;
            if ( !(double.TryParse(newFistName, out conFirstName)) && txtUpdateFirstName.Text != "" )
            {
                
                newStud.UpdateStudentNames(newFistName);
                lblUpdateMessege.Text = "First name has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid first name.");
            }
            
        }

        private void btnUpdateLastName_Click(object sender, EventArgs e) // the user updates their last name
        {
            //txtUpdateLastName
            string newLastName = txtUpdateLastName.Text;
            double conLastName;
            if ( !(double.TryParse(newLastName, out conLastName)) && txtUpdateLastName.Text != "" )
            {
                newStud.UpdateStudentLastNames(newLastName);
                lblUpdateMessege.Text = "Last name has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid last name");
            }
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e) // the user updates their address
        {
            //txtUpdateAddress
            
            string newAddress = txtUpdateAddress.Text;
            if (txtUpdateAddress.Text != "")
            {
                newStud.UpdateStudentAddress(newAddress);
                lblUpdateMessege.Text = "Address has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid address.");
            }
        }

        private void btnUpdatePhoneNumber_Click(object sender, EventArgs e) // the user updates their phone number
        {
            //txtUpdatePhoneNumber
            
            string rawPhoneNumber = txtUpdatePhoneNumber.Text;
            int newPhoneNumber;
            if (int.TryParse(rawPhoneNumber, out newPhoneNumber) && txtUpdatePhoneNumber.Text != "")
            {
                // newStud.UpdateStudentPhoneNumber(newPhoneNumber); //<-- Can't convert int to String
                lblUpdateMessege.Text = "Phone number has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e) // the user updates their Email
        {
            //txtUpdateEmail
            string newEmail = txtUpdateEmail.Text;
            if (txtUpdateEmail.Text != "")
            {
                newStud.UpdateStudenEmail(newEmail);
                lblUpdateMessege.Text = "Email has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid Email.");
            }
        }
    }
}
