using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    internal class Computer
    {
        public Computer()
        {
            BuildDate = DateTime.Now;
        }
        public Computer(string name, string graphicCard, string cpu, int ram, bool hasFloppy)
        {
            Name = name;
            BuildDate = DateTime.Now;
            GraphicCard = graphicCard;
            CPU = cpu;
            RAM = ram;
            HasFloppy = hasFloppy;
        }

        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string GraphicCard { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public bool HasFloppy { get; set; }

        public string IsEnoughRam()
        {
           switch (RAM)
           {
                case < 8:
                    return "Not enough RAM";
                case < 16:
                    return "Enough RAM";
                case >= 16:
                    return "A lot";
           }
        }
        //begginer friendly
        public void PrintInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Build Date: {BuildDate}");
            Console.WriteLine($"Graphic Card: {GraphicCard}");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Has Floppy: {HasFloppy}");
            Console.WriteLine("-----------------------------");
        }

        //the right way to override ToString method
        public override string ToString()
        {
            return $"Name: {Name}, Build Date: {BuildDate}, Graphic Card: {GraphicCard}, CPU: {CPU}, RAM: {RAM}, Has Floppy: {HasFloppy}";
        }
    }
}
