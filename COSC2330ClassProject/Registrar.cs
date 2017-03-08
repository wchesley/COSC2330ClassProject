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

        public void AddStudent(string fName, string lName, string theAddress, string thePhoneNumber, string thePass, string theEmail, string theID) // take data from form and plug into database. 
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand insertNewStudent = connection.CreateCommand())
            {
                insertNewStudent.CommandText = "insert into dbo.StudentDatabase values ('" + fName + "', '" + lName + "', '" + theAddress + "', '" + thePhoneNumber + "', '"+ thePass +"', '" + theEmail + "')";
                insertNewStudent.ExecuteNonQuery();
            }
        }

        public void ReadStudentID(string fName, string lName, string theAddress, string thePhoneNumber, string thePass, string theEmail, out string theID) // take data from form and plug into database. 
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            theID = "";
            using (SqlCommand readNewStudentID = connection.CreateCommand())
            {
                readNewStudentID.CommandText = "select * from dbo.StudentDatabase where FirstName = '" + fName + "' and LastName = '" + lName + "'and Address = '" + theAddress + "'and PhoneNumber = '" + thePhoneNumber + "'and Password = '" + thePass + "'and Email = '" + theEmail + "'";
                using (SqlDataReader reader = readNewStudentID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        theID = reader.GetString(7);
                    }
                }
            }
        }
        //I'll take a look at these errors in class today (3/1/2017) 
        //Krista already has error messages in the UI, so I don't think you need to worry about them or tryparsing here? Maybe we need to remove them from the UI and let all the error handling be done in the dll.
        public void AddProfessor(string fName, string lName, string address, string tempPhone, string email, string tempFax = "") //moved back from gui, reason: to support more OOD (seperation of gui from business logic) 
        {   //hard coded fax to be blank in method call as it should make that number optional, needs testing first. 
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            long phone = 0000000000; //changed phone and fax to long datatype
            long fax = 0000000000;
            if (long.TryParse(tempPhone, out phone) && tempPhone != null && tempPhone != "") //if it's a number and not blank
            {

            }
            else
            {
                MessageBox.Show(tempPhone, " is not a valid phone number. Please try again");
            }
           
            
             //if (long.TryParse(tempFax, out fax) && tempFax != null && tempFax != "") //testing to see if it's a number and not blank. 
             //{

             //}
             //else
             //{
             //    MessageBox.Show(tempFax + " is not a valid fax number, please try again ");
             //}
            
            using(SqlCommand insertNewProfessor = connection.CreateCommand())
                {
                 insertNewProfessor.CommandText = "INSERT into dbo.InstructorDatabase VALUES '" + fName +
                    "'" + lName + "'" + address + "'" + phone + "'" + email + "'" + fax + ";";
                connection.Open();
                insertNewProfessor.ExecuteNonQuery();
                connection.Close();
                //try
                //{
                //    connection.Open();
                //    insertNewProfessor.ExecuteNonQuery();
                //}
                //catch
                //{
                //    MessageBox.Show("Error Saving New Professor, Please try again");
                //}
                //finally
                //{
                //    //MessageBox.Show(fName + " " + lName + " was added successfully!");
                //    connection.Close();
                //}

                }
                
            

        }


    }
}