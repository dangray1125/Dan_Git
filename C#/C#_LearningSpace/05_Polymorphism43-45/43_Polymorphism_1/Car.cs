namespace _43_Polymorphism_1
{
    public class Car
    {
        public int HP{get;set;}
        public string Color{get; set;}

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("This car has {0} horsepower!", this.HP);
            System.Console.WriteLine("This car is {0}", this.Color);
        }

        public virtual void Repair()
        {
            System.Console.WriteLine("This car was repaired");
        }
    }
}