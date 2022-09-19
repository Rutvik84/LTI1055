using System;

namespace consoleassmedicine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            medicine m1 = new medicine();
            medicine m2 = new medicine(1002,"dolo",100.23f,d,category.Orthopologist);
            Console.WriteLine(m1);
            Console.WriteLine(m2);







        }
    }
}
