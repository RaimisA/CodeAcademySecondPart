using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_GenericsUzd
{
    internal class Generator<T>
    {
        public void Show(T value)
        {
            Console.WriteLine(value);
        }
    }
}
