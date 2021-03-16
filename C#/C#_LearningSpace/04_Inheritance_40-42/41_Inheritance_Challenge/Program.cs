using System;

namespace _41_Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss1 = new Boss("Richard Bugna", "Rich",100000,"lambo");
            Trainnee trainnee1 = new Trainnee("Michelle Saviano","Michelle",20000,"M-W 12:00pm-4:30pm.","M-W 8:00am-11:00am and all day Th and Fri.");

            System.Console.WriteLine(boss1.ToString());
            boss1.Lead();
            System.Console.WriteLine();

            Employee.Work();
            Employee.Pause();
            System.Console.WriteLine();

            System.Console.WriteLine(trainnee1.ToString()); 
            trainnee1.Work();

        }
    }
}
