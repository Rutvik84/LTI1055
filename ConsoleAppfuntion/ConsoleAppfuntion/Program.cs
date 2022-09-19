using System;

namespace ConsoleAppfuntion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Sum(32, 12);
            Sub(32, 12);
            Mul(32, 12);
            Div(32, 12);
            Console.ReadKey();
        }
        //this is function def.

        public static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b));
        }

        // NAMED PARAMETERS
        public static void Getdetails(string name,int age,string designation)
        {
            Console.WriteLine();
        }

    }
}
