using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_InheritanceUzd.uzduotys
{
    internal class Manager : Employee
    {
        public Manager(string name, double salary, List<Employee> employees) : base(name, salary)
        {
            Employees = employees;
        }
        public List<Employee> Employees { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Manager {0} gains {1} has {2} employees", Name, Salary, Employees.Count);
        }
    }

}

