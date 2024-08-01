using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Truck : Vehicle
    {
        public Truck(string make, string model, int year, double loadCapacity) : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }
        public double LoadCapacity { get; set; }

        public override void DisplayVehicleInfo()
        {
            Console.WriteLine($"Truck: {Make} {Model} {Year}, Load Capacity: {LoadCapacity} tons");
        }
    }
}
