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
        private void GetData()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;");
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT CourseCode, CourseName, Department, CourseTime, Capacity Filled, Sections, Professor FROM dbo.CourseDatabase", connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dataGridView1.DataSource = ds.Tables["ss"];
            }
            catch
            {
                MessageBox.Show("No records found.");
            }


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
