//using  System;
//using  System.Data;
//using  System.Data.SqlClient;

//namespace console_connected_ADO
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                SqlConnection con = new SqlConnection("Data Source=RUTVIK-SAVKARE;Initial Catalog=LTIDB;Integrated Security=True");



//                SqlCommand com = new SqlCommand();
                
//                com.Connection = con;

//                com.CommandText = "select ID,Name,Marks from Students";
//                con.Open();
//                SqlDataReader dr = com.ExecuteReader();
//                while(dr.Read())
//                {
//                    Console.WriteLine(dr[0]+" "+ dr[1] + " " + dr[2]  );
//                }
//                con.Close();


//                //Console.WriteLine("Connected Successfully");
//            }




//            catch (SqlException Ex)
//            {
//                Console.WriteLine(Ex.Message);
//            }
//        }
//    }
//}

