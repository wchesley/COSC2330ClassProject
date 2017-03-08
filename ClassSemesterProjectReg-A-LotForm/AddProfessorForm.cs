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
            double conFirstName; //This is just to make sure the user doesnt enter a number for a name
            double conLastName; // This is jsut to make sure the user doesnt enter a number for a name
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

                        

                            if (txtEmail.Text != "")
                            {


                            //registrar.AddProfessor(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text, txtFax.Text); 
                            
                           // rawFirstName = txtFirstName.Text;
                            rawLastName = txtLastName.Text;
                            address = txtAddress.Text;
                            rawphonenumber = txtPhoneNumber.Text;
                            userFax = txtFax.Text;
                            errorOccured = false;
                            registrar.AddProfessor(rawFirstName, rawLastName, address, rawphonenumber, userEmail, userFax); //moved here from line 66 ~Walker

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
                                MessageBox.Show("Please enter an Email.");

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
            if (MessageBox.Show("Are you done adding professors?", "Add Professor", MessageBoxButtons.YesNo) == DialogResult.No)
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
                // Return to RegistrarForm

                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                this.Hide();
                
            }
        }

       
    }
}
