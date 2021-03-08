using System;

namespace _14_ifStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature?");
            try
            {
                int temp = int.Parse(Console.ReadLine());
                if(temp<=32){
                    Console.WriteLine("The temperature is {0}, that is freezing!",temp);
                }
                else if ((temp > 32) && (temp < 70)){
                    Console.WriteLine("The temperature is {0}, that is cold but not freezing.",temp);
                }
                else{
                    Console.WriteLine("The temperature is {0}, that is NICE!",temp);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Not a valid input.");
            }

            Console.Read();
        }
    }
}
