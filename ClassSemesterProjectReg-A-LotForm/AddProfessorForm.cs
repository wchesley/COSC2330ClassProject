using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COSC2330ClassProject; 

namespace ClassSemesterProjectReg_A_LotForm
{
    public partial class AddProfessorForm : Form
    {
        Registrar registrar = new Registrar(); 
        public AddProfessorForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Go to RegistrarForm

        }
        //
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            registrar.AddProfessor(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNumber.Text, txtFax.Text);
        }
    }
}
