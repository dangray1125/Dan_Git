namespace _43_Polymorphism_1
{
    public class BMW:Car
    {
        public string Model {get;set;}
        private string Brand = "BMW";

        public BMW (int hp, string color , string model):base(hp,color)
        {
           this.Model = model;  
        }
        public override void ShowDetails()
        {
            System.Console.WriteLine("This is a {0}, {1} {2}, with {3} horsepower",this.Color, Brand, this.Model, this.HP);
        }
        public override void Repair()
        {
            System.Console.WriteLine("This {0} {1}, has been repair.",Brand, this.Model);
        }
    }
}