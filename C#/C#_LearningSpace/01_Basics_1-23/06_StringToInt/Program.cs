using System;

namespace _06_StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string userNumber;
            userNumber = Console.ReadLine();
            int num = 0;
            num = Int32.Parse(userNumber);
            Console.WriteLine("{0} has been converted from a string to a number",num);
            Console.Read();
        }

    }
}
