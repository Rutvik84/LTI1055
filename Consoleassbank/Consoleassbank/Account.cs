using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleassbank
{
    internal class Account
    {
        int account_id;
        String name;
        String address;
        float balance;

        public Account()
        {
             account_id = 101 ;
             name = "abc";
             address = "Mumbai" ;
             balance = 10000.23f;
        }

        public Account(int a, string b, string c, float d)
        {
            account_id = a;
            name = b;
            address = c;
            balance = d;
        }

        public override string ToString()
        {
            return "the Account id is :" + account_id + "\n name :" + name + "\n address :" + address +"\n balance" + balance;
        }

        public static void with(double balance, double withdraw)
        {
            Console.WriteLine("Balance:",+balance);
        }

        public static void deposit(double balance, double deposit)
        {
            balance = balance + deposit;
            Console.WriteLine("Balance:", +balance);
        }


    }
}
