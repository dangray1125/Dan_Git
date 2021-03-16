namespace _41_Inheritance_Challenge
{
    public class Boss:Employee
    {
        public string Car {get;set;}

        public Boss() {}
        
        public Boss(string name, string firstName, int salary, string car)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            Car = car;
        }

        public void Lead()
        {
            System.Console.WriteLine("I am leading you in this work");
        }
        public override string ToString()
        {
            return string.Format("Hi I am {0}, {1} my salary is ${2} and I drive a {3}.", this.FirstName, this.Name, this.Salary, this.Car);
        }
    }
}