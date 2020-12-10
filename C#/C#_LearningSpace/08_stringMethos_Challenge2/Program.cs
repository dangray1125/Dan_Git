/*
Challenge String and its methods 2
Let’s create another console application for more practice.

This application asks the user to input a string in the first line like “Enter a string here: ”.

In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”

On the third line, it should write the index of the first occurrence of the searched character from the string.

Now on concatenation...

It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.

It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. 
Try to store the full name in a variable, before displaying it.

*/


using System;

namespace _08_stringMethos_Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            string charLookup;
            charLookup = Console.ReadLine();
            Console.WriteLine("Enter the character you want to find the index of.");
            string myChar;
            myChar = Console.ReadLine();
            int indexChar;
            indexChar = (charLookup.IndexOf(myChar));
            Console.WriteLine("Your character {0} is founf at index: {1}",myChar,indexChar);

            Console.WriteLine("Enter you first name");
            string fName;
            fName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lName;
            lName = Console.ReadLine();
            string spaceSaver = " ";
            string name =String.Concat(fName, spaceSaver, lName);

            Console.WriteLine(name);
            Console.Read();
        }
    }
}
