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
    }
}
