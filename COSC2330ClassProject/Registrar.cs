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
            string password = fName;  
            long phone = 0000000000; //changed phone and fax to long datatype
            long fax = 0000000000;
            if (long.TryParse(tempPhone, out phone) && tempPhone != null && tempPhone != "") //if it's a number and not blank
            {

            }
            else
            {
                MessageBox.Show(tempPhone, " is not a valid phone number. Please try again");
            }


            if (long.TryParse(tempFax, out fax) && tempFax != null && tempFax != "") //testing to see if it's a number and not blank. 
            {

            }
            else
            {
                MessageBox.Show(tempFax + " is not a valid fax number, please try again ");
            }

            using (SqlCommand insertNewProfessor = connection.CreateCommand())
                {
                
                insertNewProfessor.CommandText = "INSERT INTO dbo.InstructorDatabase VALUES ('"+ fName + "', '"+ lName +"', '"+ address +"', '"+ phone + "', '"+ password +"', '"+  email +"', '"+ fax +"')";
                try
                {
                    connection.Open();
                    insertNewProfessor.ExecuteNonQuery();
                    MessageBox.Show("Instructor added, returing to form");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                    
                  
                 }
                
               

            }
                
            

        }


    }