
//write Area function to overloaded for circle , rectangle, triangle

using System;

namespace assignment3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            area(3);
            area(2, 4);
            area(3, 1.5f);

        }

        public static void area(int r)
        {
            double Res = Math.PI * r * r;
            Console.WriteLine("Area of circle= " + Res);
        }
        public static void area(int l, int b)
        {
            int Res = l * b;
            Console.WriteLine("Area of Rectangle= " + Res);
        }
        public static void area(int b, float h)
        {
            double Res = 0.5 * b * h;
            Console.WriteLine("Area of Triangle= " + Res);
        }
    }
}