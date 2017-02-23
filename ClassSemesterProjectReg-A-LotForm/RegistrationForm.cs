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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            //When Login button is clicked, pull up LoginForm
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            double conFirstName;
            double conLastName;
            
            
            if (double.TryParse(rawFirstName, out conFirstName) || txtFirstName.Text == "") // Checks to make sure the first name is a valid name
            {
                MessageBox.Show("Please re-Enter your first name.");

                if (double.TryParse(rawLastName, out conLastName) || txtLastName.Text == "") // Checks to make sure the last name is a valid name
                {
                    MessageBox.Show("Please re-enter your last name.");
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            string userAddress = txtAddress.Text; // Stores the address the user entered
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string userPhoneNumber = txtPhoneNumber.Text; // Stores the phone number the user entered
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text; // Stores the Email the user entered
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string userFirstName = txtFirstName.Text; // Stores the users first name
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string userLastName = txtLastName.Text; // Stores the users last name
        }
    }
}
