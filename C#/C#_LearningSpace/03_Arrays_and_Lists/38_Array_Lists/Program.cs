using System;
using System.Collections;

namespace _38_Array_Lists
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an ArrayList with an undefined amoung of objects
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with a defined amount of objects.
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Turkey");
            myArrayList.Add(13.52);
            myArrayList.Add(15);
            myArrayList.Add(28);
            myArrayList.Add(25.7);
            myArrayList.Add("Monkey");

            // delete and element with a specific value from arraylist
            myArrayList.Remove(15);

            // delete an element at a specific index
            myArrayList.RemoveAt(0);

            System.Console.WriteLine("The List length is: {0}",myArrayList.Count);
            System.Console.WriteLine();


            double sum = 0;
            System.Console.WriteLine("This list contains:");
            foreach(object obj in myArrayList)
            {
                System.Console.WriteLine(obj);
                
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += Convert.ToDouble(obj);
                }
                // else if (obj is string)
                // {
                //     System.Console.WriteLine(obj);
                // }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("The sum of the numbers is {0}", sum);
            Console.ReadKey();




        }
    }
}
