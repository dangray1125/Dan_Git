using System;

namespace _20_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
           //Runs code once before checking the condition
           int i = 0;  //counter
           do
           {
              Console.WriteLine(i); 
              i++;
           } while (i<10);
           Console.WriteLine();
           Console.WriteLine();

           int lengthOfText = 0;
           string wholeText = "";
           do
           {
               Console.WriteLine("Please enter the name of a friend.");
               string nameOfAFriend = Console.ReadLine();
               int currentLength = nameOfAFriend.Length;
               lengthOfText += currentLength;
               wholeText += nameOfAFriend + " ";
           } while (lengthOfText < 20);
           Console.WriteLine("Thank you that is enough length is more than 20! "+ wholeText);
           Console.ReadLine();
        }
    }
}
