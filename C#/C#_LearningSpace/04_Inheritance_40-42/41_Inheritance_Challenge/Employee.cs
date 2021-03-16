using System;
namespace _41_Inheritance_Challenge
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName {get; set;}
        public int Salary{get;set;}

        public Employee()
        {
            Name = "your name";
            FirstName = " your first name";
            Salary = 25000;
        }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public static void Work()
        {
            System.Console.WriteLine("Working hours are Mon-Fri: 8:00am - 4:30pm.");
        }
        public static void Pause()
        {
            System.Console.WriteLine("Off hours are after 4:30pm on weekdays and the weekends");
        }

         public override string ToString()
        {
            return string.Format("Hi I am {0}, {1} my salary is ${2}.", this.FirstName, this.Name, this.Salary);
        }
    
    }
    
    
}