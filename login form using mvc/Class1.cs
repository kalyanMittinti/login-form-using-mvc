using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
     
namespace login_form_using_mvc
{
    public class Class1
    {
        

        public static void insert(studentclass s) 
        {
            //Read the data from Web.Config to DataBase
            string sqlcom = System.Configuration.ConfigurationManager.ConnectionStrings["datacs"].ConnectionString;
            //Create connection
            SqlConnection con = new SqlConnection(sqlcom);
            //Pass Connection
            SqlCommand cmd = new SqlCommand("INSERT INTO student(Name, email, password) VALUES('" + s.name + "', '" + s.email + "', '" + s.password + "')", con);
            //open Connection
            con.Open();
            //Excute Query
            cmd.ExecuteNonQuery();
            //Close Query
            con.Close();

        }

    }
}