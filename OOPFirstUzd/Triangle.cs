using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Triangle
    {
        public Triangle()
        {
        }
        public Triangle(double tBase, double tHeight)
        {
            Base = tBase;
            Height = tHeight;
        }
        public Triangle(double tBase, double aSide, double bSide)
        {
            Base = tBase;
            ASide = aSide;
            BSide = bSide;
        }

        public double Base { get; set; }
        public double Height { get; set; }
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double GetArea()
        {
            return Base * Height / 2;
        }
        public double GetPerimeter()
        {
            return Base + ASide + BSide;
        }
    }
}
