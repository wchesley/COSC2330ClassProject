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
    public partial class UpdateStudentInfoForm : Form
    {
        public UpdateStudentInfoForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Open StudentForm
            StudentForm frm = new StudentForm();
            frm.Show();
        }

        private void btnUpdateFirstName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
