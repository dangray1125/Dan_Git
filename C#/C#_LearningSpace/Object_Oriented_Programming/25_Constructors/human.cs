using System;

namespace _25_Constructors
{
    public class human
    {
        //member variable
        //can be private because you are initializing it via constructor.
       private string firstName;  //can also us firstName = "Name" this will default everything to name until changed by the object
       private string lastName;
       private string eyeColor;
       private int age;

       // Constructor: 
    //    public human(String myFirstName, string lastName)
    //    {
    //        firstName = myFirstName;// two ways ... this.firstName is more popular
    //        this.lastName = lastName;
    //    } 

        public human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, my name is {0} {1}. I am {2}, with {3} eyes.",firstName, lastName, age, eyeColor);
        }
        
    }
}