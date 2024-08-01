using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{ 
    public abstract class Human
    {
        public List<Vehicle> Vehicles { get; private set; }

        public Human()
        {
            Vehicles = new List<Vehicle>();
        }
        public abstract void AddVehicle(Vehicle vehicle);
    }
}
