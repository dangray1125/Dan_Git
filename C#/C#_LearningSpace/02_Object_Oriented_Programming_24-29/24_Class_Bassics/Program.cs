using System;

namespace _24_Class_Bassics
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Create an object of my class or an instance of Human
            // human dan = new human();
            
            // //access public variables from outside or even change it
            // dan.firstName = "Dan";
            
            // //Call methods of the class
            // dan.IntroduceMyself();

            // human Mike = new human();

            // Mike.firstName = "Mike";
            // Mike.IntroduceMyself();

            //Challenge 
            // - Create a public variable lastName of type string.
            // - Change the introduceMyself method, so that it tells the whole name;
            // - create two object with full information about themselves - firstName and lastName

            human Chris = new human();

            Chris.firstName = "Chris";
            Chris.lastName = "Smith";

            Chris.IntroduceMyself();

            human Mark = new human();
            Mark.firstName = "Mark";
            Mark.lastName = "Franco";
            
            Mark.IntroduceMyself();        

            Console.ReadKey();
        }      
    }
}
