using System;

namespace _36_JaggedArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string [][] friend = new string[3][];
            friend[0]= new string []{"Mike","Chris","Charlie","Frank","Peter"};
            friend[1]= new string []{"Rob", "Megan","Cindy"};
            friend[2]= new string []{"Martha","Tyler","Kate", "George"};

           System.Console.WriteLine("Hi {0}, I'd like to introduce you to {1}.", friend[0][0],friend[2][3]);
           System.Console.WriteLine("Hi {0}, I'd like to introduce you to {1}.", friend[2][2],friend[0][2]);
           System.Console.WriteLine("Hi {0}, I'd like to introduce you to {1}.", friend[1][2], friend[2][1]);
           Console.ReadLine();
        }


    }
}
