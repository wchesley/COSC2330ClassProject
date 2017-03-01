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
    public partial class UpdateTeacherInfoForm : Form
    {
        public IUpdateableForm previousForm { get; set; }

        public UpdateTeacherInfoForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Go to TeacherForm
            //TeacherForm frm = new TeacherForm();
            //frm.Show();
            ((Form)previousForm).Show();
            //previousForm.Popu
            previousForm.PopulateForm();
            this.Hide();
        }

        private void btnUpdateFirstName_Click(object sender, EventArgs e)
        {
            string newFirstName = txtUpdateFirstName.Text;
            double conFirstName;
            if ( !(double.TryParse(newFirstName, out conFirstName)) && txtUpdateFirstName.Text != "")
            {
                Professor newProf = new Professor();
                
                newProf.UpdateInstructorFirstName(newFirstName);
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
                Professor newProf = new Professor();
                newProf.UpdateInstructorLastName(newLastName);
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
                Professor newProf = new Professor();
                newProf.UpdateInstructorAddress(newAddress);
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
            long newPhoneNumber;
            if(long.TryParse(rawPhoneNumber, out newPhoneNumber) && txtUpdatePhoneNumber.Text != "")
            {
                Professor newProf = new Professor();
                newProf.UpdateInstructorPhoneNumber(rawPhoneNumber);
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
                Professor newProf = new Professor();
                newProf.UpdateInstructorEmail(newEmail);
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
            long newFax;
            if (long.TryParse(rawFax, out newFax) && txtUpdateFax.Text != "")
            {
                Professor newProf = new Professor();
                newProf.UpdateInstructorFax(rawFax);
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
