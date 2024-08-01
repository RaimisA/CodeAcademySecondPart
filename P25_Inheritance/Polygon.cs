using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_Inheritance
{
    public class Polygon
    {
        public Polygon()
        {
            NumberofAngles = 0;
        }

        public Polygon(int numberofAngles)
        {
            NumberofAngles = numberofAngles;
        }

        public int NumberofAngles { get; set; }
        //get perimeter
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
