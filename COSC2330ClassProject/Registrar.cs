using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Windows.Forms; 
namespace COSC2330ClassProject
{
    public class Registrar 
    {
        AddUser addForRegistrar = new AddUser();
        SqlConnection connection = new SqlConnection();

        // db login info: db1 pass: db10 

        public void AddStudent() // take data from form and plug into database. 
        { 
            
        }
        //I'll take a look at these errors in class today (3/1/2017) 
        //Krista already has error messages in the UI, so I don't think you need to worry about them or tryparsing here? Maybe we need to remove them from the UI and let all the error handling be done in the dll.
        public void AddProfessor(string fName, string lName, string address, string tempPhone, string email, string tempFax = "") //moved back from gui, reason: to support more OOD (seperation of gui from business logic) 
        {   //hard coded fax to be blank in method call as it should make that number optional, needs testing first. 
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;"; 
            int phone = 0000000000;
            int fax = 0000000000;
            if (int.TryParse(tempPhone, out phone) && tempPhone != null && tempPhone != "") //if it's a number and not blank
            {

            }
            else
            {
                MessageBox.Show(tempPhone, " is not a valid number. Please try again");
            }
           
            
             if (int.TryParse(tempFax, out fax) && tempFax != null && tempFax != "") //testing to see if it's a number. 
             {

             }
             else
             {
                 MessageBox.Show(tempFax + " is not a valid number, please try again ");
             }
            
            using(SqlCommand insertNewProfessor = connection.CreateCommand())
                {
                 insertNewProfessor.CommandText = "INSERT into db_owner.Instructor VALUES (@fName,@lName,@address,@phone,@fax,@email)";
                try
                {
                    connection.Open();
                    insertNewProfessor.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Error Saving New Professor, Please try again");
                }
                finally
                {
                    connection.Close();
                }

                }
                
            MessageBox.Show(fName + " " + lName + " was added successfully!");

        }


    }
}