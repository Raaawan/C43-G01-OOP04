using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle
    {
        //Q2) Create a class named Rectangle with the following constructors:
        //●	A parameterless constructor that sets the width and height to 0.
        //●	A constructor that accepts width and height as integers.
        //●	A constructor that accepts a single integer and sets both width and height to that value.

        #region properties
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region constructors
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int number)
        {
            Width = number;
            Height = number;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Width is {Width}\nHeight is {Height} ";
        }
        #endregion
    }
}
