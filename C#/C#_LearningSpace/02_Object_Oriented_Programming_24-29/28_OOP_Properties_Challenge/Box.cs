using System;
namespace _28_OOP_Properties_Challenge
{
    // Challenge 
    // Create a read only prperty "FrontSurface which calculats the 
    // front surface based on height and length us both methods of property 
    // setters and getters. Call fr
    
    public class Box
    {
        private int length;
        public int Height { get; set; }
        public int FrontSurface
        {
            get
            {
                return this.length * this.Height;
            }
        }
        
        public Box (int length, int Height)
        {
            this.length = length;
            this.Height = Height;
        }
      
    }
}