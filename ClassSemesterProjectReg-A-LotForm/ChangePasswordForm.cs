using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COSC2330ClassProject; //Added reference to this dll in ClassSemesterProjectReg-A-LotForm


namespace ClassSemesterProjectReg_A_LotForm
{
    public partial class ChangePasswordForm : Form
    {
        AddUser resetPass = new AddUser(); 
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
            string Password = "";

            if (txtOldPassword.Text != "" )
            {
                if (txtNewPassword.Text != "" && txtNewPassword.Text != txtOldPassword.Text )
                {
                    if (txtNewPassword.Text == txtNewPassword2.Text)
                    {
                        Password = resetPass.HashPass(txtNewPassword2.Text); //Hashes password before storing it.
                        
                        // Store Password in database with the students info
                        lblPasswordUpdated.Text = "Password successfully updated.";
                    }
                    else
                    {
                        MessageBox.Show("New passwords must both match.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a new password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter your old password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordUpdated_Click(object sender, EventArgs e)
        {

        }
    }
}
