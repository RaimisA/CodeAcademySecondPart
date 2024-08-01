using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_AbstractionsUzd
{
    internal class Cat : Animal
    {
        public override string MakeNoise()
        {
            Console.WriteLine("Mew mew");
            return "Mew mew";
        }
    }
}
