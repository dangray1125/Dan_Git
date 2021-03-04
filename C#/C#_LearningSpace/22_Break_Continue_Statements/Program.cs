using System;

namespace _22_Break_Continue_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i== 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (i== 3)
                {
                    Console.WriteLine("At 3 we skip!");
                    continue;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
