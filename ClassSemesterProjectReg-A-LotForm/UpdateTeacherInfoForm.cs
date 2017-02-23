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
        public UpdateTeacherInfoForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Go to TeacherForm
            TeacherForm frm = new TeacherForm();
            frm.Show();
        }
    }
}
