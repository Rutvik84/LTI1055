﻿
//use swich case statemnet to do arithmetic operation on input integer

using System;

namespace Consoleswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Reading First Number  
            Console.Write("Enter No1: ");
            int a = Convert.ToInt16(Console.ReadLine());
            //Reading Second Number  
            Console.Write("Enter No2: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Divsion");
            Console.WriteLine("4.Multiplication");
            
            //Reading a Choice  
            int c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Division Of Two Numbers : " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                    break;
                default:
                    Console.WriteLine("Choose Only 1 To 4 ");
                    break;
            }
            Console.ReadLine();



        }   
    } 
}
