using System;

namespace _11_ReturnMethods
{
    class Program
    {
            static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            Console.WriteLine("Hello we are going to add some numbers");
            Console.Write("Eneter your first number. ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Eneter your second number. ");
            num2 = int.Parse(Console.ReadLine());
            result = add(num1,num2);
            Console.WriteLine("The result is {0}.",result);
            Console.Read();
        }

        public static int add(int num, int num1)
        {
            Console.WriteLine("We are adding {0} + {1}.",num,num1);
            return (num+num1);
        }
        
    }
}
