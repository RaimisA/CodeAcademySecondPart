using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Store
    {
        public Store(string name, int openingYear)
        {
            Name = name;
            Date = openingYear;
            ProductName = new List<string>();
        }
        public int Date { get; set; }
        public List<string> ProductName { get; set; }
        public string Name { get; set; }
    } 
}
