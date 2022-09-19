using System;

namespace Consoleassbank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account(102,"xyz","nashik",10023.44f );
            Console.WriteLine(a1);
            Console.WriteLine(a2);

        }
    }
}
