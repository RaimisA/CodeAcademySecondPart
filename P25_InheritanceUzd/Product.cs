using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_InheritanceUzd
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Electronics : Product
    {
        public Electronics(string name, double price) : base(name, price)
        {
            Warranty = DateTime.Now.AddYears(2);
        }
        public DateTime Warranty { get; set; }
    }
}
