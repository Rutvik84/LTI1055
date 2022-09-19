using System;
using System.Data;
using System.Data.SqlClient;

namespace link1exam
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=RUTVIK-SAVKARE;Initial Catalog=LTIDB;Integrated Security=True");
            try
            {

                SqlCommand com = new SqlCommand();

                com.Connection = con;
                com.CommandText = "update student set name=@name,marks=@marks where Id=@id";
                SqlParameter P = new SqlParameter("@id", SqlDbType.Int);
                Console.WriteLine("Enter Id of student to change data");
                int id = Convert.ToInt32(Console.ReadLine());
                P.Value = id;
                com.Parameters.Add(P);
                
                SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar);
                Console.WriteLine("Enter Id of student to change data");
                string Name = Console.ReadLine();
                p1.Value = Name;
                com.Parameters.Add(p1); 



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




    
