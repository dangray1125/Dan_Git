using System;

namespace _35_Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarring and intializing jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            
            jaggedArray[0] = new int[] {2,3,4,7,11};
            jaggedArray[1] = new int[] {1,2,3};
            jaggedArray[2] = new int[] {13,21};

            // alternative method
            int [][] jaggedArray2 = new int [][]
            {
                jaggedArray[0] = new int[] {2,3,4,7,11},    //element 1
                jaggedArray[1] = new int[] {1,2,3},         //element 2
                jaggedArray[2] = new int[] {13,21}          //element 3
            };
            // accessing values
            System.Console.WriteLine("The value in the middle of the first entry jaggedArray is {0}", jaggedArray[0][2]);
            System.Console.WriteLine("The value in the middle of the second entry jaggedArray2 is {0}", jaggedArray2[1][1]);
            System.Console.WriteLine();

            //challenge print all the values from jaggedArray2 on the console
            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                System.Console.WriteLine("Element {0}:",i+1);
                for(int j = 0; j < jaggedArray2[i].Length; j++)
                {                 
                    System.Console.Write(jaggedArray2[i][j]+" ");
                }
                System.Console.WriteLine();
          }

        }
    }
}
