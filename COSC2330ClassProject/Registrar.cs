using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
namespace COSC2330ClassProject
{
    public class Registrar 
    {
        AddUser addForRegistrar = new AddUser();
        SqlConnection connection = new SqlConnection();

        //public void AddStudent(); // I am thinking that when the registrar clicks on add new student
        // we can just redirect them to the student sign up page, allowing them to add a new student
        //without creating a new form or method to handle it
        //{

        //}
        public void AddProfessor(string fName, string lName, int DOB, string address, int zip, string state)
        {
        // code to add to DB I was thinking an if block to chose from prof or registrar for student
        // we can just redirect to the student registration form. ie:
            // if addprofessor is selected on registrars add user form, then go to code to 
            // add to professor DB
            // if addRegistrar, then goto code to add new Registrar. 
            //I'd imagine the code will be similar but we'll need to change the address of the DB depending on 
            // what they want to add. 
        }
        
    }
}