using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Book
    {
        public Book(string name, string author, int year, string country) 
        {
            Name = name;
            Author = author;
            Year = year;
            Country = country;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }

    }
}
