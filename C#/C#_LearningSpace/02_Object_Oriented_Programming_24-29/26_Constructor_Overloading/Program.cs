using System;

namespace _26_Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructors can be overloaded and being able to create multiple versions of the constructor storing different number of variables.
            Human mark = new Human();
            mark.IntroduceMyself();

            Human mike = new Human("Mike");
            mike.IntroduceMyself();

            Human chris = new Human("Chris", "Smith");
            chris.IntroduceMyself();

            Human frank = new Human("Frank" ,"Brown" ,"hazel");
            frank.IntroduceMyself();

            Human jose = new Human("Jose", "Diaz", "green", 22);
            jose.IntroduceMyself();
        }
    }
}
