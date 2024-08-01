using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_GenericsUzd
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return Base * Height;
        }
        public override string ToString()
        {
            return $"Figure {Name} of {Base} and {Height} has an area of {GetArea()}";
        }
       
    }
}
