using System;

namespace _19_For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for(int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            
            // Console.WriteLine();
            // Console.WriteLine();
            
            // for(int i = 0; i < 10; i+=2)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.ReadLine();

            //Write a program that prints out the odd numbers between 0 and 20

            for(int i = 0; i < 20; i++)
            {
                if (i%2 !=0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
