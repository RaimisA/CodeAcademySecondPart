using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    internal class Laptop(string name, string graphicCard, string cpu, int ram, bool hasFloppy)
    {
        public string Name { get; set; } = name;
        public DateTime BuildDate { get; set; }
        public string GraphicCard { get; set; } = graphicCard;
        public string CPU { get; set; } = cpu;
        public int RAM { get; set; } = ram;
        public bool HasFloppy { get; set; } = hasFloppy;
    }


}
