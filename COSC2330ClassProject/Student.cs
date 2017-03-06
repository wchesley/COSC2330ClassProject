using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace COSC2330ClassProject
{
    public class Student
    {
        public string CurrentStudentID { get; set; }
        SqlConnection connection = new SqlConnection(); 
        public void PopulateStudentRecord(out string name, out string address, out string phoneNumber, out string password, 
            out string email, out string ID)
        {
            name = "";
            address = "";
            phoneNumber = "";
            password = "";
            email = "";
            ID = ""; 
            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            

            using (SqlCommand readAllStudentRecords = connection.CreateCommand())

                //This code will select what ever the current student ID is.
            {
                readAllStudentRecords.CommandText = "SELECT * FROM db1.StudentDatabase WHERE paddedID= @ID";
                readAllStudentRecords.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(CurrentStudentID);
                connection.Open();
                using (SqlDataReader reader = readAllStudentRecords.ExecuteReader())
                {         
                    while (reader.Read())
                    {
                        name = reader.GetString(1) + " " + reader.GetString(2);
                        address = reader.GetString(3);
                        phoneNumber = reader.GetString(4);
                        password = reader.GetString(5);
                        email = reader.GetString(6);
                        ID = reader.GetString(7);
                    }
                }
            }


            connection.Close();
            //return studentRecord;
        }
        public void UpdateStudentNames(string fname)
        {


            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateStudentrFirstName = connection.CreateCommand())
            {
                updateStudentrFirstName.CommandText = "update dbo.StudentDatabase set FirstName = '" + fname + "' where ID = 1";
                updateStudentrFirstName.ExecuteNonQuery();
            }
        }
        public void UpdateStudentLastNames(string lname)
        {


            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateStudentrLastName = connection.CreateCommand())
            {
                updateStudentrLastName.CommandText = "update dbo.StudentDatabase set LastName = '" + lname + "' where ID = 1";
                updateStudentrLastName.ExecuteNonQuery();
            }
        }
        public void UpdateStudentID(string studentID)
        {
            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateSudentID = connection.CreateCommand())
            {
                updateSudentID.CommandText = "update dbo.StudentDatabase set ID = '" + studentID + "' where ID = 1";
                updateSudentID.ExecuteNonQuery();
            }
        }
        public void UpdateStudentAddress(string address)
        {


            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateStudentrAddress = connection.CreateCommand())
            {
                updateStudentrAddress.CommandText = "update dbo.StudentDatabase set Address = '" + address + "' where ID = 1";
                updateStudentrAddress.ExecuteNonQuery();
            }
        }

        public void UpdateStudentPhoneNumber(string phoneNumber)
        {


            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateStudentPhoneNumber = connection.CreateCommand())
            {
                updateStudentPhoneNumber.CommandText = "update dbo.StudentDatabase set PhoneNumber = '" + phoneNumber + "' where ID = 1";
                updateStudentPhoneNumber.ExecuteNonQuery();
            }
        }

        public void UpdateStudenEmail(string email)
        {


            
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateStudentEmail = connection.CreateCommand())
            {
                updateStudentEmail.CommandText = "update dbo.StudentDatabase set Email = '" + email + "' where ID = 1";
                updateStudentEmail.ExecuteNonQuery();
            }
        }

    }     
}