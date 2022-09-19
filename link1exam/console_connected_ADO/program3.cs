using System;
using System.Data;
using System.Data.SqlClient;

namespace console_connected_ADO
{
    internal class program3
    {
        static void Main(string[] args)
        {
            try
            {

                string connectionstr = "Data Source=ABCCOMPUTER;initial catalog=LTIDB;integrated security=true";
                SqlConnection con = new SqlConnection(connectionstr);
                SqlDataAdapter da = new SqlDataAdapter("select Id,name,marks from Student", con);
                DataSet ds = new DataSet();
                da.Fill(ds);



            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex.Message);
            }


        } 
    }

}
