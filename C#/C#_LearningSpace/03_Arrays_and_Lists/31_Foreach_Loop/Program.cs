using System;

namespace _31_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            

            // old method using for loop to iterate through the array
            for(int i =0; i < 10; i++)
            {
                nums[i] = i +10;
            }

            for(int j = 0; j < 10; j++)
            {
                System.Console.WriteLine("Element {0} is eqaul to: {1}", j, nums[j]);
            }

            // new method using a foreach loop
            int counter = 0;
            foreach(int item in nums)
            {
                System.Console.WriteLine("Elemente {0} is equal to {1}",counter,item);
                counter++;
            }

            // create an array with 5 of your best friends
            // create a foreach loop which greats all of them

            string[] friends = {"Amanda", "Shenniell", "Vincent", "Tyler", "Kyle"};

            foreach(string friend in friends)
            {
                System.Console.WriteLine("Hi {0}, How are you?!", friend);
            }
            Console.ReadLine();
        }
    }
}
