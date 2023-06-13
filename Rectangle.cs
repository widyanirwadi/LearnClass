using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClass
{
    /* Class */
    public class Rectangle
    {
        /* Property */
        private double Length { get; set; }

        private double Width { get; set; }

        /* Constructor */
        public Rectangle (double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        /* Method */
        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculateParimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
