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
    public partial class ScheduleForm : Form
    {
        public Form previousForm { get; set; }
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
         
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            CourseRegisterForm frm = new CourseRegisterForm();
            frm.Show();
            this.Hide();
        }

       
    }
}
