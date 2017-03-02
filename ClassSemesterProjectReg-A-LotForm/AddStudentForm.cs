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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            string address = txtAddress.Text;
            string rawphonenumber = txtPhoneNumber.Text;
            double conFirstName;
            double conLastName;
            string userAddress = txtAddress.Text; // Stores the address the user entered
            string userPhoneNumber = txtPhoneNumber.Text; // Stores the phone number the user entered
            int conPhoneNumber; //Stores the phonenumber as a int
            string userEmail = txtEmail.Text; // Stores the Email the user entered
            string userFirstName = txtFirstName.Text; // Stores the users first name
            string userLastName = txtLastName.Text; // Stores the users last name


            if (!(double.TryParse(rawFirstName, out conFirstName)) && txtFirstName.Text != "") //If name is not a number & not blank..
            {

                if (!(double.TryParse(rawLastName, out conLastName)) && txtLastName.Text != "")
                {

                    if (txtAddress.Text != "")
                    {

                        if (int.TryParse(userPhoneNumber, out conPhoneNumber) && txtPhoneNumber.Text != "")
                        {

                            if (txtEmail.Text != "")
                            {
                                MessageBox.Show("The student has been added"); //<---- replace this with the proper equivalent of: 
                                                                                //registrar.AddStudent(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text,);
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
            //-------------------------------------------
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to add another Student?", "Add Student", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
            };
        }
    }
}
