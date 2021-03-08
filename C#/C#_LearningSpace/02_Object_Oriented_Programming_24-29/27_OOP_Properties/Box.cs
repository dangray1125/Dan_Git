using System;
namespace _27_OOP_Properties
{
    public class Box
    {
       //member variables

       // unsafe implementation

    //    public int length;
    //    public int width;
    //    public int height;
    //    public int volume; 

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine("Length is {0},the height is {1} and the width is {2}, so the volume is {3}", length,height,width,volume=length*width*height);
    //    }

        // safe implementation
        private int length;
        //public int width;
        private int height;
        private int volume; 

        public int Height   //Property implementation
            {
                get
                {
                    return height;
                }
                set
                {
                    height = value;
                }

            }

        public int Width { get; set; }  // second version of property implementation
        
        public int Volume 
        {
            get
            {
                return this.length *Width * this.height;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
           Width = width;
        }

         public Box()
        {
            //this.length = length;
            this.Height = height;
            this.Width = Width;
        }


        public void SetLength(int length) //can be made private fo only inheriteing class to set
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        // public int GetVolume()
        // {
        //     return this.length * this.width * this.height; // proper to restrict access directly to the variable set by other member variables by calling fomula
        // }
        public void DisplayInfo()
        {
           Console.WriteLine("Length is {0},the height is {1} and the width is {2}, so the volume is {3}", length,height,Width,volume = length *height*Width);
        }
        }
}