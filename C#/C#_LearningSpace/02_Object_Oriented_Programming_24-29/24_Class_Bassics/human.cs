using System;

namespace _24_Class_Bassics
{
    public class human
    {
        //member variable
       public string firstName;  //can also us firstName = "Name" this will default everything to name until changed by the object

       public string lastName;
        
        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}",firstName, lastName);
        }
        
    }
}