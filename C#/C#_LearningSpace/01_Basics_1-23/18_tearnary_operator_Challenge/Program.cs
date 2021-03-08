using System;

namespace _18_tearnary_operator_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            int temperature = -5;
            string stateOfMatter;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.WriteLine();
            
            Console.WriteLine("The temperature has changed!");
            temperature +=35;
            
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            //Challeng add a 3rd state gas for temp higher than 100
            temperature +=100;
            stateOfMatter = temperature > 100 ? "gas" : temperature <0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
*/

            Console.WriteLine("Enter an integer value");
            string stringNumber = Console.ReadLine();
            //int parsedNum;
            int temperature;
            bool success = int.TryParse(stringNumber, out temperature);
            string tempIs ;
            
            if (success==true)     // this can also be done as "if (int.TryParse(stringNumber, out parsedNum)) ;"
            {
                tempIs = temperature > 28 ? "hot here" : temperature <= 15 ? "too cold here" : "ok";
                Console.WriteLine("It is {0}",tempIs);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
