using System;

namespace _27_OOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;  no longer works because length is private
            box.SetLength(3); // works because it is a method of its own class.
            box.Height = 4;
            box.Width = 5;
            
            System.Console.WriteLine("Height is "+ box.Height);
            System.Console.WriteLine("Box length is " + box.GetLength());

            box.DisplayInfo();

            Box box2 =new Box(1,2,3);
            box2.DisplayInfo();
        }
    }
}
