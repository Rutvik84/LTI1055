using System;
using System.Data;
using System.Data.SqlClient;

namespace console_connected_ADO
{
    internal class program1
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=RUTVIK-SAVKARE;Initial Catalog=LTIDB;Integrated Security=True");
            try
            {
                
                SqlCommand com = new SqlCommand();

                com.Connection = con;

                com.CommandText = "insert into students (name,marks)values(@name,@marks)";
                SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);
                Console.WriteLine("Enter name of new student ");
                string name = Console.ReadLine();// this data is in C# string format
                p1.Value = name;// will convert it into Sql DbType varchar
                com.Parameters.Add(p1);
                //========================================== next to give marks conerted from C# to SQl
                SqlParameter p2 = new SqlParameter("@marks", SqlDbType.Int);
                Console.WriteLine("Enter marks  of new student ");
                int marks = Convert.ToInt32(Console.ReadLine());
                p2.Value = marks;                             // this data is in C# string format
                com.Parameters.Add(p2);
                con.Open();
                com.ExecuteNonQuery();// opposite to query : insert , update and delete  DML
                Console.WriteLine("Record Added Successfully");




            }
            catch (SqlException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}









            