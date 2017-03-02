using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COSC2330ClassProject; 

namespace ClassSemesterProjectReg_A_LotForm
{
    public partial class AddProfessorForm : Form
    {
        Registrar registrar = new Registrar(); 
        public AddProfessorForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
        }
        //
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            //-------------------------------------------
            string rawFirstName = txtFirstName.Text;
            string rawLastName = txtLastName.Text;
            string address = txtAddress.Text;
            string rawphonenumber = txtPhoneNumber.Text;
            double conFirstName;
            double conLastName;
            string userAddress = txtAddress.Text; // Stores the address the user entered
            string userPhoneNumber = txtPhoneNumber.Text; // Stores the phone number the user entered
            int conPhoneNumber; //Stores the phonenumber as a int
            string userFax = txtFax.Text;
            int conFax;
            string userEmail = txtEmail.Text; // Stores the Email the user entered
            string userFirstName = txtFirstName.Text; // Stores the users first name
            string userLastName = txtLastName.Text; // Stores the users last name
            bool errorOccured = false;


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
                                if (int.TryParse(userFax, out conFax) && txtFax.Text != "")
                                {
                                    // Store the information given by the end-user into the database
                                     registrar.AddProfessor(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text, txtFax.Text);
                                                                                //<--- I think this is where the other MessegeBoxes are appearing.
                                    if (errorOccured != true && MessageBox.Show("The Professor has been added, would you like to add another?", "Professor Added", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        txtFirstName.Clear();
                                        txtLastName.Clear();
                                        txtAddress.Clear();
                                        txtEmail.Clear();
                                        txtPhoneNumber.Clear();
                                        txtFax.Clear();
                                    }
                                    else
                                    {

                                    }


                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid fax number.");
                                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to add another Professor?", "Add Professor", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //Return to RegistrarForm

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
                txtFax.Clear();
            }
        }
    }
}
