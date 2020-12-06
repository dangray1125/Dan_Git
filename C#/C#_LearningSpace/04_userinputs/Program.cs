using System;

namespace _04_userinputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();               // Takes the user input and stores it as a string.
            Console.WriteLine("Your name is {0}",name);


            Console.WriteLine("Enter a character symbol to recieve its ASCII code value.");
            int asciiValue = Console.Read();                              // Takes the user input and converts it to an interger equal to its ascii equivlent
            Console.WriteLine("The ASCII code of the letter you input is: {0}",asciiValue);
        }
    }
}
