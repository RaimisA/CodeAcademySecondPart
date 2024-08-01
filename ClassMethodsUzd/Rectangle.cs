using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsUzd
{
    internal class Rectangle
    {
        public  double Height { get; set; }
        public  double Width { get; set; }
        public double RectanglePerimeter()
        {
            return 2 * (Height + Width);
        }
        public double RectangleArea()
        {
            return Height * Width;
        }

    }
    
}
