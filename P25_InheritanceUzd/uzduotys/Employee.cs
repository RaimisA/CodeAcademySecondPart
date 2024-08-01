using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_InheritanceUzd.uzduotys
{
    public class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
