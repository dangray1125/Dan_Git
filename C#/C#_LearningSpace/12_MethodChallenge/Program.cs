/*
 In this challenge you will deepen your understanding for methods.
Please go ahead and create three variables with names of your friends.
Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 

Greet all your three friends.

with the fact that i know basic programming i have modified the GreetFriend to return a string with the friend greeting me in response.
 */
using System;

namespace _12_MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Tyler";
            string friend2 = "Amanda";
            string friend3 = "Steve";
            string response;
            
            response = GreetFriend(friend1);
            Console.WriteLine(response);
            response = GreetFriend(friend2);
            Console.WriteLine(response);
            response = GreetFriend(friend3);
            Console.WriteLine(response);
            Console.Read();
        }
        public static string GreetFriend( string friend)
        {
            Console.WriteLine("Hello {0}",friend);
            return "Hello, Dan!\n";
        }
    }
}
