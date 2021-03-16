using System;
using System.Collections.Generic;

// Polymorphism is the condition occuring in several different forms 
// ie the base class Car, and two children of the class being BMW and Audi
// We use 'virtual' keyword in base methods to make them shareable between the children,
// but we must also use the 'overide' keyword in the children of the class to call and override those methods
// 'new' key word can also be used for creating a new instance of a method in a sub class.


namespace _43_Polymorphism_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW (235, "blue", "328Xi"),
                new Audi(198,"Silver", "S4")
            };

            foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();

            }
          
        }
    }
}
