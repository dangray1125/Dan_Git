using System;
using System.Collections.Generic;

// Polymorphism is the condition occuring in several different forms 
// ie the base class Car, and two children of the class being BMW and Audi
// We use 'virtual' keyword in base methods to make them shareable between the children,
// but we must also use the 'overide' keyword in the children of the class to call and override those methods
// 'new' key word can also be used for creating a new instance of a method in a sub class.
// 'sealed' keyword prevents inheritence from taking place.

namespace _44_Polymorphism_Sealed
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

            Car bmwZ = new BMW(350, "black", "Z3");
            M3 myM3 = new M3(504, "Silver", "M3");
            myM3.Repair(); // the use of the keyword "sealed' in the BMW method of repair prevents M3 from inheriting the method.
            

            foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();

            }
          
        }
    }
}
