using System;  
using System.Collections.Generic;

namespace _39_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists can only contain the same DATATYPE
            List<int> list = new List<int> {1, 4, 3, 2};
            
            System.Console.WriteLine("The list contains these integers:");
            foreach(int i in list)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();

            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);

            System.Console.WriteLine("The list contains these integers:");
            foreach(int i in list)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine();
            System.Console.Write("Check to see if the list contains '4': ");
            System.Console.WriteLine(list.Contains(4));

            int index = list.FindIndex(x => x == 4); //(x => x == 4) is a lambda expression
            System.Console.WriteLine("The index of 4 is : {0}", index);
            System.Console.WriteLine();

            list.RemoveAt(index);
            
            System.Console.WriteLine("The list contains these integers:");
            list.ForEach(i => Console.WriteLine(i)); //(i => Console.WriteLine(i)) is a lambda expression again.

            

        
        
        }
    }
}
