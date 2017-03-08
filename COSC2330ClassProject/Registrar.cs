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

        public Registrar()
        {
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
        }
        //I'll take a look at these errors in class today (3/1/2017) 
        //Krista already has error messages in the UI, so I don't think you need to worry about them or tryparsing here? Maybe we need to remove them from the UI and let all the error handling be done in the dll.
        public void AddProfessor(string fName, string lName, string address, string tempPhone, string email, string tempFax = "") //moved back from gui, reason: to support more OOD (seperation of gui from business logic) 
        {   //hard coded fax to be blank in method call as it should make that number optional, needs testing first. 
            //SqlConnection connection = new SqlConnection();

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
            
            using(SqlCommand insertNewProfessor = connection.CreateCommand())
                {
                 insertNewProfessor.CommandText = "INSERT into dbo.InstructorDatabase VALUES '" + fName +
                    "'" + lName + "'" + address + "'" + phone + "'" + email + "'" + fax + ";";
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
                    //MessageBox.Show(fName + " " + lName + " was added successfully!");
                    connection.Close();
                }

                }

         

                
            

        }

        //Search by name here
        //----------------------------------------------------

        public void searchProfessorIDNumber(string ProfIDNumber) // Search by ProfessorID number
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand readAllIDNumbers = connection.CreateCommand())
            {
                readAllIDNumbers.CommandText = "select * from dbo.StudentDatabase where ID like '%" + ProfIDNumber + "%";
                using (SqlDataReader reader = readAllIDNumbers.ExecuteReader())
                {
                    string records = "";
                    while (reader.Read())
                    {
                        records += reader.GetString(0) + "";
                    }

                }
            }
            connection.Close();
        }


        public void searchLast(string LastName) // Search by Student last name
        {
            using (SqlCommand readAllLastName = connection.CreateCommand())
            {
                readAllLastName.CommandText = "select from dbo.StudentDatabase where LastName '%" + LastName + "%";
                using (SqlDataReader reader = readAllLastName.ExecuteReader())
                {
                    string record = "";
                    while (reader.Read())
                    {
                        record += reader.GetString(2) + "";
                    }
                }
            }
            connection.Close();
        }
        public void searchStudentIDNumber(string StudentIDNumber) //  Search by Student ID
        {
            connection.Open();
            using (SqlCommand readAllStudentID = connection.CreateCommand())
            {
                readAllStudentID.CommandText = "select * from dbo.StudentDatabase where ID '%" + StudentIDNumber + "%";
                using (SqlDataReader reader = readAllStudentID.ExecuteReader())
                {
                    string record = "";
                    while (reader.Read())
                    {
                        record += reader.GetString(0) + "";
                    }
                }
            }
            connection.Close();
        }

        public void searchCourseNumber(string courseNumber)
        {
            // Search/read from database where courseName = userInput
            // Show all matching courseNames in the dataGridCourse
            // Clear all other courseNames from the dataGridCourse

        
            connection.Open();
            using (SqlCommand readAllCourseNumbers = connection.CreateCommand()) // Search by course number
            {
                
                readAllCourseNumbers.CommandText = "select * from dbo.CourseDatabase where CourseCode like '%" + courseNumber + "%'";

                using (SqlDataReader reader = readAllCourseNumbers.ExecuteReader())
                {
                    string records = "";
                    while (reader.Read())
                    {
                        records += reader.GetString(1) + "";
                         
                    }
                }
            }
            connection.Close();
        }
        public void searchCourseProfessor(string professorName) // Search by Professor name
        {
            using (SqlCommand readAllProfessorLastNames = connection.CreateCommand())
            {
                readAllProfessorLastNames.CommandText = "select * from dbo.CorseDatabase where Professor like '%" + professorName + "%";

                using (SqlDataReader reader = readAllProfessorLastNames.ExecuteReader())
                {
                    string records = "";
                    while (reader.Read())
                    {
                        records += reader.GetString(6) + "";
                    }
                    connection.Close();
                }
            }
        }
        public void searchCourseName(string courseName)
        {
            using (SqlCommand readAllCourseNames = connection.CreateCommand())
            {
                readAllCourseNames.CommandText = "select * from dbo.CourseDatabase where CourseName like '%" + courseName + "%";

                using (SqlDataReader reader = readAllCourseNames.ExecuteReader())
                {
                    string records = "";
                    while (reader.Read())
                    {
                        records += reader.GetString(2) + ""; // course Name
                    }
                    connection.Close();
                }
                

            }
        }

    }
}
