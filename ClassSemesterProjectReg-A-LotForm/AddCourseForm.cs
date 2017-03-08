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
            string courseDepartment;
            int courseTime = 0;
            int conCourseCode = 0;
            int courseSection = 0;
            bool errorOccured = false;
            
            if (txtCourseName.Text != "")
            {
                //Store courseName in the database
                txtCourseName.Text = courseName;
                if (int.TryParse(courseCode, out conCourseCode) && txtCourseCode.Text != "" && conCourseCode >= 1000 && conCourseCode <= 9999)
                {
                    if (cmbTimeSlot.Text == "8:00am -  9:00am" && cmbTimeSlot.Text != "")
                    {
                        courseTime = 800; // Store time in database
                    }
                    else if (cmbTimeSlot.Text == "9:30am - 10:30am" && cmbTimeSlot.Text != "")
                    {
                        courseTime = 930; // Store time in database
                    }
                    else if (cmbTimeSlot.Text == "11:00am - 12:30pm" && cmbTimeSlot.Text != "")
                    {
                        courseTime = 1100; // Store time in database
                    }
                    else if (cmbTimeSlot.Text == "1:00pm - 2:00pm" && cmbTimeSlot.Text != "")
                    {
                        courseTime = 1300; // Store time in database
                    }
                    else if (cmbTimeSlot.Text == "2:30pm - 3:30pm " && cmbTimeSlot.Text != "")
                    {
                        courseTime = 1530; // Store time in database
                    }
                    else
                    {
                        MessageBox.Show("Please pick a time slot.");
                        errorOccured = true;
                    }

                    if (cmbSection.Text == "1" && cmbSection.Text != "")
                    {
                        courseSection = 1; // Store section in database
                    }
                    else if (cmbSection.Text == "2" && cmbSection.Text != "")
                    {
                        courseSection = 2; // Store section in database
                    }
                    else if (cmbSection.Text == "3" && cmbSection.Text != "")
                    {
                        courseSection = 3; // Store section in database
                    }
                    else
                    {
                        MessageBox.Show("Please pick a section.");
                        errorOccured = true;
                    }

                        if (cmbDepartment.Text != "")
                        {

                        courseName = txtCourseName.Text;
                        courseDepartment = cmbDepartment.Text;
                        courseCode = txtCourseCode.Text;

                        Courses frm = new Courses();
                        frm.AddCourse(courseName, courseCode, courseSection, courseTime, courseDepartment);
                        }

                        else
                        {
                            MessageBox.Show("Please enter a course department.");
                        errorOccured = true;
                        }
                    if (errorOccured != true && MessageBox.Show("The Course has been added, would you like to add another?", "Course Added", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtCourseName.Clear();
                        txtCourseCode.Clear();
                        
                    }
                    else
                    {

                    }
                }
                
                else
                {
                    MessageBox.Show("Please enter a 4 digit number for the course code.");
                    errorOccured = true;
                }

                
            }
            else
            {
                MessageBox.Show("Please enter a course name.");
                errorOccured = true;
            }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you done adding courses?", "Add Courses", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else
            {
                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                this.Hide();

            }
            
        }
    }

        
        }
 
