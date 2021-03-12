using System;

namespace _30_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and intialize
            int[] grades =new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] =8;

            Console.WriteLine("Grades at index 0: {0}", grades[0]);
            string input = Console.ReadLine();
            //assign new value
            grades[0]= int.Parse(input);
            System.Console.WriteLine("Grades at index 0 is now: {0}",grades[0]);
            Console.ReadLine();

            // another way of initialization
            int[] gradesOfMathStudentsA = {20,20,19,15,9};

            //third way of initialization of arrays
            int[] gradesOfMathStudentsB = new int[]{ 15,13,9,19,17};

            System.Console.WriteLine("Length of gadesOfMathStudentsA: {0}",gradesOfMathStudentsA.Length);
            Console.ReadLine();
        }
    }
}
