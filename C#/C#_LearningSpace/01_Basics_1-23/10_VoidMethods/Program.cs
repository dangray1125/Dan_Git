using System;

namespace _10_VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           SayHello();
           Console.Read();
        }
        
        public static void SayHello()                       // due to main being static the void function must also be static and must be between the
        {                                                   // access modifyer and name.
            System.Console.WriteLine("Hello");
        }


    }
}
