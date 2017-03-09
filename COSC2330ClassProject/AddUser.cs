﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data; 
using System.Windows.Forms;

using ClassSemesterProjectReg_A_LotForm;

namespace COSC2330ClassProject
{
    public class AddUser  
    {

        public string HashPass(string password) // tested; hashing is consistant 
        {  //might just remove this function due to time constrants. 
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
        
        public bool VerifyLogin(string userID, string pass)
        {
            // search DB for UserID
            // if UserID == null
            // tell end user that user doesn't exist
            //if UserID is found check the password they entered
            //agains the one we have stored in the DB
            // if they match, then go to student or professor profile page
            //else login failed, password incorrect.
            bool exists; 
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            
            //pass = HashPass(pass); // hash pass to match against hashed pass in DB. might end up abandoning hashing 
            using(SqlCommand readAllStudents = connection.CreateCommand())
                {
                    readAllStudents.CommandText = "SELECT paddedID, password FROM Project1.dbo.StudentDatabase WHERE paddedID= @ID AND Password = @Password";
                
                    readAllStudents.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(userID); // Assigns the @ID param in the readAllStudents call. also converts it the SQL data type.
                    readAllStudents.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = pass; 
                    connection.Open();
                using (SqlDataReader reader = readAllStudents.ExecuteReader()) 
                {
                    exists = reader.HasRows;
                    if (exists == true)
                    {
                        Student newStud = new Student();
                        newStud.CurrentStudentID = userID;
                        MessageBox.Show("Login Validated");
                        MessageBox.Show(userID); 
                        StudentForm frm = new StudentForm();
                        frm.Show();

                        
                    }
                    else
                    {
                        connection.Close(); // if student login fails, check instructor, this is closing the student DB so we can open the instructor. 
                        readAllStudents.CommandText = "SELECT paddedID, password FROM Project1.dbo.InstructorDatabase WHERE paddedID= @ProfID AND Password = @ProfPassword";

                        readAllStudents.Parameters.Add("@ProfID", SqlDbType.Int).Value = Convert.ToInt32(userID);  
                        readAllStudents.Parameters.Add("@ProfPassword", SqlDbType.VarChar, 50).Value = pass;
                        connection.Open();
                        using (SqlDataReader ProfReader = readAllStudents.ExecuteReader())
                        {
                            exists = ProfReader.HasRows;
                            if(exists == true)
                            {
                                Professor newProf = new Professor();
                                newProf.CurrentProfesorID = userID;
                                MessageBox.Show("Instructor login validated");
                                TeacherForm frm = new TeacherForm();
                                frm.Show();
                                
                                
                                //I think login is working, need to test further by actually pulling up data from the DB
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid User ID or Password, Please try again. "); 
                            }
                            connection.Close();
                            
                        }
                    }
                     
                }
                return exists; 
               

            }

            

        }


        
    }
}