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
    public partial class RegistrarForm : Form
    {
        public RegistrarForm()
        {
            InitializeComponent();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            AddTeacherForm frm = new AddTeacherForm();
            frm.Show();
            this.Hide();
        }

        private void btnUpdateProfessor_Click(object sender, EventArgs e)
        {
            AddTeacherForm frm = new AddTeacherForm();
            frm.Show();
            this.Hide();

        }
    }
}
