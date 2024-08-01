using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_Generics
{
    internal class GenericClass<T>
    {
        private T? Data;

        public void Set(T data)
        {
            Data = data;
        }
        public T Get()
        {
            return Data;
        }
    }
}
