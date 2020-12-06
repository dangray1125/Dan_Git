using System;

namespace _05_dataConversion
{
    class Program
    {
        static void Main(string[] args)
        {     
            double myDouble = 69.5942;
            int myInt;

            myInt = (int)myDouble;      //EXPLICIT casting.
            Console.WriteLine("myDouble was explicitly casted to int.  " + myInt);
            
            float myFloat =35.76F;
            myDouble = myFloat;  //implicit casting
            Console.WriteLine("mydouble was implicitly casted to an int "+ myDouble);
        
            string myString = myDouble.ToString();
            string my2String = myFloat.ToString();

            Console.WriteLine("my2String is a type cast from a float to a string. "+ my2String);
            Console.Read();

        }
    }
}
