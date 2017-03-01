using System;
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
        
        
        public void AddStudent(string fName, string lName, int phoneNum, string address)
        {
            // Take info from form and add to student DB, check to ensure userID doesn't already exist. 
            // add each item to the data base, unsure how we want to store addresses. 
            //using (SqlCommand insertNewStudent = connection.CreateCommand() )
            //{
            //    // adding the student information to the DB, mostly incomplete here till we get DB access. 
            //    insertNewStudent.CommandText = "insert into databasename.Student values = ("fName + lName + pass + email + address + state + zipCode";";
            //        //will need to fix above error, will test when DB access is aquired.
            //    insertNewStudent.ExecuteNonQuery(); 
            //}
            // Should return a message if successful and display userID to user
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
        }

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
            return strBuilder.ToString(); // returns hash as string. weill go to be stored in database
            //need to build verification system aswell. 
            //verification system for it still. 
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
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            pass = HashPass(pass); // hass pass to match against hashed pass in DB.
            using(SqlCommand readAllStudents = connection.CreateCommand())
                {
                    readAllStudents.CommandText = "SELECT * FROM db_owner.StudentDatabase where ID='"+ userID+ "'";
                using(SqlDataReader read = readAllStudents.ExecuteReader())
                    {
                        // check password if userID exists
                        // else check ProfessorDatabase
                    }
                }

            

        }


        
    }
}