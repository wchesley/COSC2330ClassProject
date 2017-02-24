using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;

namespace COSC2330ClassProject
{
    public class AddUser //Might have Registrar inherit or use this class and then they can add admin and professor
        //accounts from there. just at thought. 
    {
        SqlConnection connection = new SqlConnection();
        
        public void addUser(string fName, string lName, string pass, string email, string address, string state, int zipCode)
        {
            // Take info from form to register
            // add each item to the data base, unsure how we want to store addresses. 
            // (Might just format all as string?) - changed to seperate values. 
            // might be easier that way
            connection.ConnectionString = "server=cis1.actx.edu;Database=project;User Id=project;Password=password;";
            // ConncectionString is just full of placeholders till we get the actual DB info
            HassPass(pass);
            using (SqlCommand insertNewStudent = connection.CreateCommand() )
            {
                // adding the student information to the DB, mostly incomplete here till we get DB access. 
                insertNewStudent.CommandText = "insert into databasename.Student values = ("fName  lName + pass + email + address + state + zipCode";";
                    //will need to fix above error, will test when DB access is aquired.
                insertNewStudent.ExecuteNonQuery(); 
            }
        }

        public string HassPass(string password) // To securly store passwords, haven't fully tested yet. 
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
        private string ResetPassword(string userID, int DOB)
        {
            string newpassword = "";
            // search for user ID & DOB in DB, verify with what end user has enterd
            // if data is validated, offer two text boxes to change password 
            //write change to DB after hashing it.
            return HassPass(newpassword); 
        }
        public void LoginVerify()
        {
            // take info from login screen and verify against DB. 
        }


        
    }
}