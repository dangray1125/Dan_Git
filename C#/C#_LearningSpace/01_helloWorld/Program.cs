using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi Dan!");
            Console.Read(); //Line needed for Windows OS only to keep console cli open, doesnt afffect MacOS of linux if used.
        }
    }
}
