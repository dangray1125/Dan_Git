using System;

namespace _37_Arrays_as_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] {15, 13, 8, 12, 6, 16}; 
            double studentAverage = GetAverage(studentsGrades);
            System.Console.WriteLine("The student average is: {0}",studentAverage);
            System.Console.WriteLine();
            System.Console.WriteLine();


            int[] happiness = new int[] {10, 20, 30, 40, 50};
            System.Console.WriteLine("Happiness before increase:");
            foreach(int happyLevel in happiness)
            {
                System.Console.WriteLine(happyLevel);
            }
            
            IncreaseHappiness(happiness);
            
            System.Console.WriteLine("Happiness after increase:");
            foreach(int happyLevel in happiness)
            {
                System.Console.WriteLine(happyLevel);
            }
            Console.ReadKey();
        }
      
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for( int i = 0; i < size; i++)
            {
                sum += gradesArray[i]; 
            }
            average = (double)sum/size;
            return average;
        }
        static void IncreaseHappiness(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i]+=2;
            }
           
        }
    }
}
