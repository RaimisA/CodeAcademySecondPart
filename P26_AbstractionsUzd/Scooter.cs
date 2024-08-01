using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Scooter : Vehicle
    {
        public Scooter(string make, string model, int year, bool isElectric) : base(make, model, year)
        {
            IsElectric = isElectric;
        }
        public bool IsElectric { get; set; }

        public override void DisplayVehicleInfo()
        {
            Console.WriteLine($"Scooter: {Make} {Model} {Year}, Electric: {IsElectric}");
        }     
    }
}
