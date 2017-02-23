using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography; 

namespace COSC2330ClassProject
{
    public class AddUser //Might have Registrar inherit or use this class and then they can add admin and professor
        //accounts from there. just at thought. 
    {
        public void addUser(string fName, string lName, string pass, string email, string address, string state, int zipCode)
        {
            // Take info from form to register
            // add each item to the data base, unsure how we want to store addresses. Might just format all as string?
            HassPass(pass);
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
            return strBuilder.ToString(); // returns hash as string. weill go to be stored in database, need c
            //verification system for it still. 
        }
    }
}