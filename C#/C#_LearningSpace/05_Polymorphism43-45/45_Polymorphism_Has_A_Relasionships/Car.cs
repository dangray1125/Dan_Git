namespace _45_Polymorphism_Has_A_Relasionships
{ 
    public class Car
    {
        public int HP{get;set;}
        public string Color{get; set;}

        //has a relationship
        protected CarIdInfo carIDInfo = new CarIdInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIdInfor()
        {
            System.Console.WriteLine("The consol has the ID number of {0} and the owner of it is {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }

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