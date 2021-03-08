using System;

namespace _numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 11;
            int num2 = 25;
            int sum = num1 + num2;

            double numd1 = 33.333;
            double numd2 = 55.5;
            double sumd = numd1 + numd2;

            float numf1 = 3.5F; // the 'F' following the number is required or it is considered a double.

            
            Console.WriteLine("The sum of "+ num1 + " + "+ num2 +" is "+sum+".");   
            Console.WriteLine("The sum of "+ numd1 + " + "+ numd2 +" is " +sumd+".");
            Console.WriteLine("The floating point number "+ numf1);
            Console.Read(); //Line needed for Windows OS only to keep console cli open, doesnt afffect MacOS of linux if used.
        }
    }
}