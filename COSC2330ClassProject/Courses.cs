using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Sql;
using System.Data.SqlClient;



namespace COSC2330ClassProject
{
    public class Courses
    {
        // We found a different solution to this problem.

        //    public void PopulateCourseData(out string theCode, out string theName, out string theDepartment,
        //        out int theTime, out int theCap, out int theSection, out string theProfessor)
        //{
        //    theCode = "";
        //    theName = "";
        //    theDepartment = "";
        //    theTime = 0;
        //    theCap = 0;
        //    theSection = 0;
        //    theProfessor = "";

        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
        //    connection.Open();
        //    using (SqlCommand readCourseData = connection.CreateCommand())
        //    {
        //        readCourseData.CommandText = "select * from dbo.CourseDatabase";
        //        using (SqlDataReader reader = readCourseData.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                theCode = reader.GetString(1);
        //                theName = reader.GetString(2);
        //                theDepartment = reader.GetString(3);
        //                theTime = reader.GetInt32(4);
        //                theCap = reader.GetInt32(5);
        //                theSection = reader.GetInt32(6);
        //                theProfessor = reader.GetString(7);

        //            }
        //        }
        //    }
        //}

        public void AddCourse(string theName, string theCode, int theSection, int theTime, string theDepartment)
        {
            //theName = "";
            //theCode = "";
            //theSection = 0;
            //theTime = 0;
            //theDepartment = "";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project1;User Id=db1;Password = db10;";
            connection.Open();

            using (SqlCommand insertNewCourse = connection.CreateCommand())
            {
                insertNewCourse.CommandText = "insert into dbo.CourseDatabase values ('"+ theCode +"', '"+ theName +"', '"+ theDepartment +"', '"+ theTime +"', 0, '"+ theSection +"', 'No Professor')";
                insertNewCourse.ExecuteNonQuery();
            }

        }
    }
}