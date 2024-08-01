using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P31_Generics
{
    internal class Repository<T> where T : Vegetable
    {
        private readonly List<T> list = new List<T>();

        public void Add(T data)
        {
            list.Add(data);
        }
        public List<T> Get()
        {
            return list;
        }
        public void Remove(T data)
        {
            list.Remove(data);
        }
        public bool Contains(T data)
        {
            return list.Contains(data);
        }
        public T GetByIndex(int id)
        {
            var val = list[0];
            return list.Find(x => x.Id == id);
        }
    }
}
