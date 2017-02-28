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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text;
            string courseCode = txtCourseCode.Text;
            int conCourseCode;
            // Course time, and Department are stored in Combobox. Do you think that would work?
            

            if (txtCourseName.Text != "")
            {
                if (int.TryParse(courseCode, out conCourseCode) && txtCourseCode.Text != "")
                {
                    //if (ComboBox FOR TIME)
                    //{
                    //    if (ComboBox FOR DEPARTMENT)
                    //    {

                    //    }
                    //    else
                    //    {

                    //    }
                    //}
                    //else
                    //{

                    //}
                }
                else
                {
                    MessageBox.Show("Please enter a valid course code number.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a course name.");
            }

            if(MessageBox.Show("Would you like to add another course?", "Add Course", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //Return to RegistrarForm
                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                this.Hide();

            }
            else
            {

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to add another Course?", "Add Course", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //Return to RegistrarForm

                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                this.Hide();

            }
            else
            {

            }
        }
    }
}
