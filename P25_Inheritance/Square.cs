using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_Inheritance
{
    public class Square : Polygon
    {
        public Square()
        {
            NumberofAngles = 4;
        }

        public Square(double size)
        {
            Size = size;
            NumberofAngles = 4;
        }

        public double Size { get; set; }
        public override double GetPerimeter()
        {
            return Size * NumberofAngles;
        }
    }
}
