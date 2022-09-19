using System;

namespace Console_ref_out_param_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members(1055, "Durga", "prerna", "unnati");

        }

        // params keyword is used to pass an array of undecided length as a parameter
        public static void Members(int branchcode, params string[] names)
        {
            Console.WriteLine("Branch Code is " + branchcode);

            foreach (string n in names)

            {
                Console.WriteLine("name :" + n);
            }

        }
    }
}
