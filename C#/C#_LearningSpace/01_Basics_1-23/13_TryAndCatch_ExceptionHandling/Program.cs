using System;

namespace _13_TryAndCatch_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter a number");
            
            try
            {
                int input = int.Parse(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("That was not a number please try again");
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number was too large");
            }
            finally
            {
                Console.WriteLine("I run anyway!");
                //finally runs after "try" passes of gets caught to signify you have left the try/catch and can be used to close connections to servers.
            }

            //catch (Exception) catches all Exceptions but can specify as seen above. can also see the function's 
            // exceptions by mousing over the Objects method  "Parse' of int.Parse()

            int num1= 35;
            try
            {
            int result =num1/0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine ("Error can not divide by zero");
            }
            Console.ReadKey();
        }
    }
}
