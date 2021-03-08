using System;

namespace _16_IfChallenge
{
    class Program
    {
        static string userName;
        static string passWord;
        static void Main(string[] args)
        {
            Register();
            Login();



            Console.ReadKey();

        }

        public static void Register()
            {
                Console.WriteLine("Hello, enter a new user name.");
                userName = Console.ReadLine();
                Console.WriteLine("Enter a password for this account.");
                passWord = Console.ReadLine();
                Console.WriteLine("You are now registered!");
                Console.WriteLine("------------------------------------------");
            }

        public static void Login()
            {
                Console.WriteLine("Lets log in");
                Console.WriteLine("Enter your User Name");
                if (userName == Console.ReadLine())
                {
                    Console.WriteLine("Enter your password");
                    if (passWord == Console.ReadLine())
                    {
                        Console.WriteLine("Login Success!");
                    }
                    else
                    {
                        Console.WriteLine("Login Failed Wrong password. Please restart and try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Login Failed Wrong username. Please restart and try again.");
                }
            }
    }
}
