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
    public partial class UpdateStudentInfoForm : Form
    {
        public Form previousForm { get; set; }
        public UpdateStudentInfoForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Should return to the previous form when the button is clicked
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
                lblUpdateMessege.Text = "Email has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid Email.");
            }
        }
    }
}
