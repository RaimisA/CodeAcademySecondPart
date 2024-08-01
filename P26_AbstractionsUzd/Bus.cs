using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Bus : Vehicle
    {
        public Bus(string make, string model, int year, int passengerCount) : base(make, model, year)
        {
            PassengerCount = passengerCount;
        }
        public int PassengerCount { get; set; }

        public override void DisplayVehicleInfo()
        {
            Console.WriteLine($"Bus: {Make} {Model} {Year}, Capacity: {PassengerCount}");
        }
    }
}
