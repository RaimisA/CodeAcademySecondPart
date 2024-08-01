using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Triangle : GeometricShape
    {
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override double GetArea()
        {
            var triangleArea = Math.Sqrt((Side1 + Side2 + Side3) * (Side1 + Side2 - Side3) * (Side1 - Side2 + Side3) * (-Side1 + Side2 + Side3)) / 4;
            Console.WriteLine("Triangle Area: ");
            return triangleArea;
        }
      

        public override double GetPerimeter()
        {
            var trianglePerimeter = Side1 + Side2 + Side3;
            Console.WriteLine("Triangle Perimeter: ");
            return trianglePerimeter;
        }
    }
}
