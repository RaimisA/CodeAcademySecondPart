using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Circle
    {
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
