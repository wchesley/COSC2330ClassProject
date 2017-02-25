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
    public partial class AddProfessorForm : Form
    {
        public AddProfessorForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Go to RegistrarForm

        }
        public void AddProfessor(string fName, string lName, string address, string tempPhone, string email, string tempFax = "") //moved here from Registrar class
        {   //hard coded fax to be blank in method call as it should make that number optional, needs testing first. 
            int phone = 0000000000;
            int fax = 0000000000; 
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            address = txtAddress.Text;
            tempPhone = txtPhoneNumber.Text;
            tempFax = txtFax.Text;
            email = txtEmail.Text;
            if(int.TryParse(tempPhone, out phone) && txtPhoneNumber.Text != null) //if it's a number and not blank
            {

            }
            else
            {
                MessageBox.Show(txtPhoneNumber.Text, " is not a valid number. Please try again");
            }
            if (txtFax.Text != "" || txtFax.Text != null)
            {
                if (int.TryParse(tempFax, out fax))
                {

                }
                else
                {
                    MessageBox.Show(txtFax.Text + " is not a valid number, please try again ");
                }
            }
            // Then write info to DB
            MessageBox.Show(fName + " " + lName + " was added successfully!" );
             
        }
        
    }
}
