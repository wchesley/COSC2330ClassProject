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
    public partial class UpdateTeacherInfoForm : Form
    {
        public Form previousForm { get; set; }

        public UpdateTeacherInfoForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Go to TeacherForm
            //TeacherForm frm = new TeacherForm();
            //frm.Show();
            previousForm.Show();
            this.Hide();
        }

        private void btnUpdateFirstName_Click(object sender, EventArgs e)
        {
            string newFirstName = txtUpdateFirstName.Text;
            double conFirstName;
            if ( !(double.TryParse(newFirstName, out conFirstName)) && txtUpdateFirstName.Text != "")
            {
                // Add newFirstName to database to update the old one?
                lblUpdateMessege.Text = "First name has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid fist name.");
            }
            
        }

        private void btnUpdateLastName_Click(object sender, EventArgs e)
        {
            string newLastName = txtUpdateLastName.Text;
            double conLastName;
            if ( !(double.TryParse(newLastName, out conLastName)) && txtUpdateLastName.Text != "")
            {
                // newLastName should replace the old one (probably in the database)
                lblUpdateMessege.Text = "Last name has been updated";
            }
            else
            {
                MessageBox.Show("Please enter a valid last name.");
            }
            
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            string newAddress = txtUpdateAddress.Text;
            if (txtUpdateAddress.Text != "")
            {
                // newAddress should replace the old one (probably in the database)
                lblUpdateMessege.Text = "Address has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid address.");
            }
        }

        private void btnUpdatePhoneNumber_Click(object sender, EventArgs e)
        {
            string rawPhoneNumber = txtUpdatePhoneNumber.Text;
            int newPhoneNumber;
            if(int.TryParse(rawPhoneNumber, out newPhoneNumber) && txtUpdatePhoneNumber.Text != "")
            {
                // newPhoneNumber should replace the old one (probably in the database)
                lblUpdateMessege.Text = "Phone number has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            string newEmail = txtUpdateEmail.Text;
            if (txtUpdateEmail.Text != "")
            {
                // newEmail should replace the old one (probably in the database)
                lblUpdateMessege.Text = "Email has been updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        private void btnUpdateFax_Click(object sender, EventArgs e)
        {
            string rawFax = txtUpdateFax.Text;
            int newFax;
            if (int.TryParse(rawFax, out newFax) && txtUpdateFax.Text != "")
            {
                // newFax should replace the old one (Probably in the databse)
                lblUpdateMessege.Text = "Fax number updated.";
            }
            else
            {
                MessageBox.Show("Please enter a valid fax number.");
            }
        }
    }
}
