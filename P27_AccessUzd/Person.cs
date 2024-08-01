using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccessUzd
{
     class Person
    {
        protected string name;
        protected int age;

        public string Name { get { return name; } private set { name = value; } }

        protected void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
