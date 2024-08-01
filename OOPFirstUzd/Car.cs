using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Car
    {
        

        public Car()
        {
            Engine = new Engine();
        }
        public Engine Engine { get; private set; }

        public void StartEngine()
        {
            Engine.Start();
        }
    }
}
