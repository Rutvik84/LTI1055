using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppbook
{
    internal class Book
    {
        public int Book_id;
         public  string Bname;
         public double Bprice;

        public Book()
        {
            Book_id = 2;
            Bname = "hey";
            Bprice = 101.21f;

        }
        public Book(int book_id,string N, double P)
        {
            book_id = book_id;
            Bname = Bname;
            Bprice = Bprice;    
        }






    }
}
