using System;

namespace _23_Loops1_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* WAP that calculates the average score of a professor's
            students. The professor wants to be able to enter each score 
            idividually and then get the final average when he enters -1.

            the tool should 
            -check that the entry is a number  and shoulld add that too the sum.
            -Once done entering scores the program should write the average to the console.

            Numbers entered should only be between 0 and 20. Make sure the program doesnt crash 
            if an incorrect value is entered.*/
            double average = 0;
            string stringNumber;
            int parsedNum =0;
            int count = 0;
            while (parsedNum != -1)
            {
                Console.WriteLine("Please enter a whole score between 0 and 20.");
                stringNumber = Console.ReadLine();
                if(int.TryParse(stringNumber,out parsedNum))
                {
                    if ((parsedNum >= 0) && (parsedNum <= 20))
                    {
                        average += parsedNum;
                        Console.WriteLine("{0} has been added to the average.",parsedNum);
                        count++;
                    }
                    else if (parsedNum == -1)
                    {
                        Console.WriteLine("Please wait while the average is calculated");
                    }
                    else
                    {
                        Console.WriteLine("The value {0} is an invalid entry please enter another value.",parsedNum);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value entered!");
                }  
                Console.WriteLine();                                   
            }
            Console.WriteLine();
            average = average/count;
            Console.WriteLine("The average of the {0} scores is: {1}",count,average);
        }
        Console.ReadLine();
    }
}
