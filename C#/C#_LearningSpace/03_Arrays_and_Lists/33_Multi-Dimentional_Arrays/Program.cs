using System;

namespace _33_Multi_Dimentional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a 2d array
           
           // string[,] matrix;

            // 3d array
           
           // int [,,] threeD;


            // two dimensional array
            int[,] array2D = new int[,]
            {

                {1,2,3},    //row 0
                {4,5,6},    //row 1
                {7,8,9}     //row 2
            };

            System.Console.WriteLine("Central value is {0}", array2D[1,1]);
            System.Console.WriteLine("Third row value one is {0}", array2D[2,0]);

            string [,,] array3D = new string[,,]
            {
                {
                    //First row 0
                    {"000", "001"},                 //Second row 0
                    {"010", "011"},                 //Second row 1
                    {"High there", "What up?"}      //Second row 2
                },  
                {
                    //First row 1
                    {"100","101"},                  //Second row 0
                    {"110","111"},                  //Second row 1
                    {"Another one","Last entry"}    //Second row 2

                }
                // 3D array call [First row, second row, inside contents position]
            };

            System.Console.WriteLine("The value is {0}", array3D[1,1,0]);
            System.Console.WriteLine("The value is {0}", array3D[0,2,0]);
            System.Console.WriteLine("The value is {0}", array3D[1,2,1]);


            //Other ways of initializing arrays
            string[,]  array2DString = new string[3,2] 
            {
                {"one", "two",},        //row 0
                {"three","four"},       //row 1
                {"five","six"}          //row 2
            };
            array2DString[1,1] = "chicken";
            foreach (string item in array2DString)
            {
                System.Console.WriteLine(item);
            }
            /// finding dimensions of array
            int dimensions = array2DString.Rank;
            System.Console.WriteLine("array2DString is {0} dimensions.", dimensions);
            Console.ReadKey();
        }
    }
}
