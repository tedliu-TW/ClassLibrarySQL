using System;
using System.Data.SqlClient;

namespace ClassLibrarySQL
{
    public class Class1
    {
        // test demo sql connect
        string constr = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        public void executeSql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();




        }


    }
}
