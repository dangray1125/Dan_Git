using System;

namespace _15_TryParse_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value");
            string stringNumber = Console.ReadLine();
            int parsedNum;
            bool success = int.TryParse(stringNumber, out parsedNum);

            if (success==true)     // this can also be done as "if (int.TryParse(stringNumber, out parsedNum)) ;"
            {
                Console.WriteLine("Your integer was {0}",parsedNum);
            }
            else
            {
                Console.WriteLine("Try Parse failed.");
            }
            Console.ReadKey();
        }
    }
}
