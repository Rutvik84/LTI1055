using System;

namespace ConsoleAppclassobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            date d1 = new date();
            d1.SetDay(2);
            d1.SetMonth(9);
            d1.SetYear(22);
            Console.WriteLine(d1.GetDay() + "/" + d1.Month() + "/" + d1.Year() );



        }
    }
}
