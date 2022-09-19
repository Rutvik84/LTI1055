using System;

namespace Consolehwproduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Product Product = new Product();
            Product product1 = new Product(1002,"Phone",10000.23f,d,category.e);
            Console.WriteLine(Product);
            Console.WriteLine(product1);

        }
    }
}
