using System;

namespace _03_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Dan";
            string message ="My name is " +myname; // string concatenation.
            Console.WriteLine(message); 

            string capsMessage = message.ToUpper(); //string method
            Console.WriteLine(capsMessage);

            string lowerMessage = message.ToLower();
            Console.WriteLine(lowerMessage);

            Console.Read(); //Line needed for Windows OS only to keep console cli open, doesnt afffect MacOS of linux if used.
        }
    }
}
