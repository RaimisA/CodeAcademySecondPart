using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Square
    {
        public Square()
        {
        }
        public Square(double length)
        {
            SideLength = length;
        }

        public double SideLength { get; set; }
        public double GetArea()
        {
            return SideLength * SideLength;
        }
        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

    }
}
