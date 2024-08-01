using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsUzd
{
    internal class Circle
    {
        public double Radius { get; set; }
        public double CirclePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double CircleArea()
        {
            return Math.PI * Radius * Radius;
        }
    }  
}
