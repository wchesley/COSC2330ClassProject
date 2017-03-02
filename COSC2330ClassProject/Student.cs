﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;


namespace COSC2330ClassProject
{
    public class Student
    {
        public int CurrentStudentID { get; set; }

        public void UpdateStudentNames(string fname)
        {


            SqlConnection connection = new SqlConnection();
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


            SqlConnection connection = new SqlConnection();
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
            SqlConnection connection = new SqlConnection();
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


            SqlConnection connection = new SqlConnection();
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


            SqlConnection connection = new SqlConnection();
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


            SqlConnection connection = new SqlConnection();
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