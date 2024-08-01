using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Dog : Animal
    {
        public override string MakeNoise()
        {
            Console.WriteLine("Woof woof");
            return "Woof woof";
        }
    }
}
