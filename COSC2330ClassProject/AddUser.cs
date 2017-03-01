﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace COSC2330ClassProject
{
    public class AddUser //Might have Registrar inherit or use this class and then they can add admin and professor
        //accounts from there. just at thought. 
    {

        public string HashPass(string password) // tested; hashing is consistant 
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password)); //compute hash from text entered
            byte[] result = sha.Hash; // store the hash result
            StringBuilder strBuilder = new StringBuilder(); 
            for(int i = 0; i < result.Length; i++)
            {
                // Change to 2 hexadecimal digits per byte entered. 
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString(); // returns hash as string. 
            
        }
        
        public void VerifyLogin(string userID, string pass)
        {
            // search DB for UserID
            // if UserID == null
            // tell end user that user doesn't exist
            //if UserID is found check the password they entered
            //agains the one we have stored in the DB
            // if they match, then go to student or professor profile page
            //else login failed, password incorrect.
            MessageBox.Show("VerifyLogin Method called");
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();
            //pass = HashPass(pass); // hash pass to match against hashed pass in DB.
            using(SqlCommand readAllStudents = connection.CreateCommand())
                {
                    readAllStudents.CommandText = "SELECT paddedID, password FROM Project1.dbo.StudentDatabase WHERE ID='"+ userID+ "'" + pass + ";";
                    if(readAllStudents.ExecuteNonQuery() > 0 ) 
                 {
                    
                    MessageBox.Show("Login Validated");
                 }
                else
                {
                    MessageBox.Show("Invalid");
                    //readAllStudents.CommandText = "SELECT ID , password FROM dbo.InstructorDatabase where ID='" + userID + "'" + pass + ";";
                    //if(readAllStudents.ExecuteNonQuery() > 0)
                    //{
                    //    MessageBox.Show("Login Validated");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid ID or password Please try again. ");
                    //}
                    // Not sure if it will work like this. 
                }
                 
                }

            

        }


        
    }
}