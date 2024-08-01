using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Square : GeometricShape
    {
        public Square(double side)
        {
            Side = side;
        }
        public double Side { get; set; }
        public override double GetArea()
        {
            var squareArea = Math.Pow(Side, 2);
            Console.WriteLine("Square Area: ");
            return squareArea;
        }

        public override double GetPerimeter()
        {
            var squarePerimeter = 4 * Side;
            Console.WriteLine("Square perimeter: ");
            return squarePerimeter;
        }
    }
}
