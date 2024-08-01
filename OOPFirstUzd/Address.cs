using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Address
    {
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
