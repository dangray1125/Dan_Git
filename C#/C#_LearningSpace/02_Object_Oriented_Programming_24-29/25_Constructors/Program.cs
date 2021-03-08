using System;

namespace _25_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
        //    human mark = new human("Mark", "Smith");
        //    mark.IntroduceMyself();

        // Challenge
        // add two more member variables to 'human', eyeColor and age
        // adjust the constructo, so it requires all of the 4 values to be used, when creating  the object human
        // create two objects of type human using the modified constructor

            human vince = new human("Vincent", "Nguyen", "Brown", 22);
            vince.IntroduceMyself(); 

            human dan = new human("Dan","Gray","Blue", 33);
            dan.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
