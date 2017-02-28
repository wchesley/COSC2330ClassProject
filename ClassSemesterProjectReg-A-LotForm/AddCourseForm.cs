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
            string courseTime = cmbTimeSlot.Text;
            int conCourseCode;
            
             //----------------Work in Progress
            if (txtCourseName.Text != "")
            {
               //Store the course name

            }
            else if (int.TryParse(courseCode, out conCourseCode) && txtCourseCode.Text != "")
            {
               // Store the Course Code
            }

            else if (cmbTimeSlot.Text == "8:00am -  9:00am" && cmbTimeSlot.Text != "")
            {
                //Store the time: courseTime
            }
            else if (cmbTimeSlot.Text == "9:30am - 10:30am" && cmbTimeSlot.Text != "")
            {
                //Store the time: courseTime
            }
            else if (cmbTimeSlot.Text == "11:00am - 12:30pm" && cmbTimeSlot.Text != "")
            {
                //Store the time: courseTime
            }
            else if (cmbTimeSlot.Text == "1:00pm - 2:00pm" && cmbTimeSlot.Text != "")
            {
                //Store the time: courseTime
            }
            else if (cmbTimeSlot.Text == "2:30pm - 3:30pm " && cmbTimeSlot.Text != "")
            {
                //Store the time: courseTime
                //MessageBox.Show("The course time is: " + courseTime);
            }
            // ----------------Work in Progress

            //else
            //{
            //    MessageBox.Show("Please enter a course time.");
            //}
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter a valid course code number.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a course name.");
            //}

            //if(MessageBox.Show("Would you like to add another course?", "Add Course", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    //Return to RegistrarForm
            //    RegistrarForm frm = new RegistrarForm();
            //    frm.Show();
            //    this.Hide();

            //}
            //else
            //{

            //}
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
