using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Person
    {
        public Person(string name, int age, int height) 
        {
            Name = name;
            Age = age;
            Height = height;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
    }
}
