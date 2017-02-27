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

        public void AddStudent() // take data from form and plug into database. 
        { 
            
        }
        public void AddProfessor(string fName, string lName, string address, string tempPhone, string email, string tempFax = "") //moved back from gui, reason: to support more OOD (seperation of gui from business logic) 
        {   //hard coded fax to be blank in method call as it should make that number optional, needs testing first. 
            int phone = 0000000000;
            int fax = 0000000000;
            if (int.TryParse(tempPhone, out phone) && tempPhone != null && tempPhone != "") //if it's a number and not blank
            {

            }
            else
            {
                MessageBox.Show(tempPhone, " is not a valid number. Please try again");
            }
           
            
             if (int.TryParse(tempFax, out fax) && tempFax != null && tempFax != "") //testing to see if it's a number. 
             {

             }
             else
             {
                 MessageBox.Show(tempFax + " is not a valid number, please try again ");
             }
            
            // Then write info to DB
            MessageBox.Show(fName + " " + lName + " was added successfully!");

        }


    }
}