using System;

namespace _21_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 0;
            // while(i <10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // Console.ReadLine();

            // WAP that keeps count of a number based on a key press such as enter
            //use the entering of any charater as an escape.
            int count = 0;
            string key = "";
            while(key == "")
            {
                key = Console.ReadLine();
                count++;
                Console.WriteLine(count);
            }
            Console.WriteLine("The Final Count is: {0}",count);
            Console.ReadKey();
        }
        
    }
}
