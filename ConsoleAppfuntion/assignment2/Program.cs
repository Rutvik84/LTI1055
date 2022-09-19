//pass array of friends to the function using params and display names in ascending order

using System;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members("Durga", "Rutvik", "Ragav", "John", "Shivani", "Bhavana", "Likitha", "Vikram", "Giri", "Etc");

        }

        public static void Members(params string[] names)
        {
            Array.Sort(names);
            foreach (string n in names)
            {

                Console.WriteLine(" Name :" + n);

            }

        }
    }
}

