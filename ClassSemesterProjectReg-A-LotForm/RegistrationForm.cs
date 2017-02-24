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
            // Had some thoughts on the address, it might be easier to created 
            // seperate text boxes for street name, street number, zip and state? 
            // might 

            // We're not going to be using the Address information for the actual program or anything to send out real letters so I didn't bother making multiple variables
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            string address = txtAddress.Text;
            string rawphonenumber = txtPhoneNumber.Text; 
            double conFirstName;
            double conLastName;
            //int zip;  <--- We're not going to need these as seperate variable it'll just be stored as one Address: ________ string saves work time.
            //string state; <-- just trying to cut down on work and amount of stuff we have to deal with

            string userAddress = txtAddress.Text; // Stores the address the user entered
            string userPhoneNumber = txtPhoneNumber.Text; // Stores the phone number the user entered
            int conPhoneNumber;
            string userEmail = txtEmail.Text; // Stores the Email the user entered
            string userFirstName = txtFirstName.Text; // Stores the users first name
            string userLastName = txtLastName.Text; // Stores the users last name

            // shouldn't the names stay as strings? <--(names arent being converted, this is just a check to make sure the users aren't enterting numbers for their first and last name)
            if ( !(double.TryParse(rawFirstName, out conFirstName)) && txtFirstName.Text != "") ///If name is not a number & not blank..
            {

                if ( !( double.TryParse(rawLastName, out conLastName)) && txtLastName.Text != "") 
                {
                   
                    if (txtAddress.Text != "") 
                    {
                        
                        if (int.TryParse(userPhoneNumber, out conPhoneNumber) && txtPhoneNumber.Text != "") 
                        {
                            
                            if (txtEmail.Text != "") 
                            {
                                // Store the information given by the end-user into the database
                                // Generate a user ID and password
                                // Show the user ID in place of: lblStudentID
                                // Show the user temp. Password in place of: lblStudentPassword
                                btnCreateAccount.Hide(); // hides the button so the user can't make multiple accounts with the same information
                            }
                            else
                            {
                                MessageBox.Show("Please enter an Email.");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid phone number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an address.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid last name.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid first name.");
            }
            
            
            
            
            

        }

        
    }
}
