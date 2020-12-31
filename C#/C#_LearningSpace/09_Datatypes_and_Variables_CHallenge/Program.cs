/*
Now that you know how to declare and initialize Variables, please go ahead and create a variable for each of the primitive datatypes (you can find the list here). 
Leave the Object datatype out.
And also please initialize each variable with a working value.
Then create two values of type string. 
The first one should say "I control text"

The second one should be a whole number. Then use the Parse method in order to convert that string to an integer.

Add each an output for each of the variables and write it onto the console. (WriteLine)
Feel free to name your variables as you like, but keep in mind, that my result's variable names will differ to yours.
Have fun :)
*/

using System;

namespace _09_Datatypes_and_Variables_CHallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "I control text!";
            string s2 = "35";

            int myNum= Int32.Parse(s2);
            Console.WriteLine(s1+"\n\n");
            Console.WriteLine("The number you entered in string form was {0}\n\n", myNum);
            byte myByte = 32;
            sbyte mySbyte = -56;
            int myInt = -32698;
            uint myUint = 54903;
            short myShort = -32000;
            ushort myUshort = 65000;
            long mylong  = -90000000;
            ulong myUlong = 90000000;
            float myFloat = 3.153353F;
            double myDouble = .11785343;
            char myChar = 'g';
            bool myBool = true;
            string myString = "turtle";
            decimal myDec = .55643M;
        
            Console.WriteLine("This is a list of all the variables:\nbyte: \t{0} \nsbye: \t{1} \nint: \t{2} \nuint: \t{3} \nshort: \t{4} \nushort: {5} \nlong: \t{6} \nulong: \t{7} \nfloat: \t{8} \ndouble: {9} \nchar: \t{10} \nbool: \t{11} \nstring: {12} \ndecimal: {13}",myByte,mySbyte,myInt,myUint,myShort,myUshort,mylong, myUlong,myFloat,myDouble,myChar,myBool,myString, myDec);
            Console.Read();
        }
    }
}
