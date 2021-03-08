using System;

namespace _26_Constructor_Overloading
{
    public class Human
    {
        private string firstName = null;
        private string lastName = null;
        private string eyeColor = null;
        private int age = 0;

        public Human()
        {
            Console.WriteLine("Constructor called. Object Created");
        }
    
        public Human(string firstName)
        {
            this.firstName = firstName;
                       
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }    
    
        public void IntroduceMyself()
        {
            if ((firstName == null) && (lastName == null) && (eyeColor == null) && (age == 0))
            {
                Console.WriteLine("There is nothing to introduce.");
            }
            else if ((lastName == null) && (eyeColor == null) && (age == 0))
            {
                Console.WriteLine("Hi my first name is {0}", firstName);
            }
            else if ((eyeColor == null) && (age == 0))
            {
                Console.WriteLine("Hello my name is {0} {1}.", firstName, lastName);
            }
            else if (age == 0)
            {
                Console.WriteLine("Hi my name is {0} {1}, I have {2} eyes.", firstName, lastName, eyeColor);
            }
            else
            {
                Console.WriteLine("Hi my name is {0} {1}, I have {2} eyes and I am {3} years old.", firstName, lastName, eyeColor, age);
            }
        }
    
    }
}