using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using COSC2330ClassProject;


namespace ClassSemesterProjectReg_A_LotForm
{
    public partial class CourseRegisterForm : Form
    {
        public CourseRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm frm = new ScheduleForm();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();
            frm.Show();
            this.Hide();
        }

       

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }
    }
}
