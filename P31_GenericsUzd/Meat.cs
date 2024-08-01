using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace P31_GenericsUzd
{
    internal class Meat<T1, T2>
    {
        private T1 FirstType;
        private T2 SecondType;

        public void PrintT1()
        {
            Console.WriteLine(FirstType);
        }
        public void PrintT2()
        {
            Console.WriteLine(SecondType);
        }
        public void ChangeT1(T1 value)
        {
            FirstType = value;
        }
        public void ChangeT2(T2 value)
        {
            SecondType = value;
        }
    }
}
