namespace _41_Inheritance_Challenge
{
    public class Trainnee:Employee
    {
        public string WorkingHours{get;set;}
        public string SchoolHours{get;set;}

        public Trainnee() {}
        public Trainnee(string name, string firstName, int salary, string workingHours, string schoolHours) 
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Work()
        {
            System.Console.WriteLine("My working hours are {0}", this.WorkingHours);
            System.Console.WriteLine("My education hours are {0}", this.SchoolHours);
        }

       
    }
}