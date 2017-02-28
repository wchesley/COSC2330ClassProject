using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace COSC2330ClassProject
{
    public class Professor
    {
        public int CurrentProfesorID { get; set; }


        //Currently Update only works on the Professor with ID of 1. When we get the login working I can update the code to update where Id = whoever is currently logged in.
        public void UpdateInstructorFirstName(string fName)
        {
            
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
           
            using(SqlCommand updateProfessorFirstName = connection.CreateCommand())
            {
                updateProfessorFirstName.CommandText = "update dbo.InstructorDatabase set FirstName = '" + fName + "' where ID = 1";
                updateProfessorFirstName.ExecuteNonQuery();
            }


        }

        public void UpdateInstructorLastName(string lName)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using(SqlCommand updateProfessorLastName = connection.CreateCommand())
            {
                updateProfessorLastName.CommandText = "update dbo.InstructorDatabase set LastName = '" + lName + "' where ID = 1";
                updateProfessorLastName.ExecuteNonQuery();
            }
        }

        public void UpdateInstructorAddress(string newAddress)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateProfessorAddress = connection.CreateCommand())
            {
                updateProfessorAddress.CommandText = "update dbo.InstructorDatabase set Address = '" + newAddress + "' where ID = 1";
                updateProfessorAddress.ExecuteNonQuery();
            }
        }

        public void UpdateInstructorPhoneNumber(string newPhoneNumber)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateProfessorPhoneNumber = connection.CreateCommand())
            {
                updateProfessorPhoneNumber.CommandText = "update dbo.InstructorDatabase set PhoneNumber = '" + newPhoneNumber + "' where ID = 1";
                updateProfessorPhoneNumber.ExecuteNonQuery();
            }
        }
         public void UpdateInstructorEmail(string newEmail)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateProfessorEmail = connection.CreateCommand())
            {
                updateProfessorEmail.CommandText = "update dbo.InstructorDatabase set Email = '" + newEmail + "' where ID = 1";
                updateProfessorEmail.ExecuteNonQuery();
            }
        }
        public void UpdateInstructorFax(string theFax)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand updateProfessorFax = connection.CreateCommand())
            {
                updateProfessorFax.CommandText = "update dbo.InstructorDatabase set Fax = '" + theFax + "' where ID = 1";
                updateProfessorFax.ExecuteNonQuery();
            }
        }
    }
}