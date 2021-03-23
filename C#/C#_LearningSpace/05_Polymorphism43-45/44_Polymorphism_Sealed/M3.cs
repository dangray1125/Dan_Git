namespace _44_Polymorphism_Sealed
{
    public class M3:BMW
    {
        public M3(int hp, string color , string model):base(hp,color, model)
        {
            this.Model = model;
        }
        
        public override void Repair()
        {
            base.Repair();
        }
            
        
    }
}