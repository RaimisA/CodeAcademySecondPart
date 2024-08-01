using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class School
    {
        public School(string name, string city, int pupil) 
        {
            Name = name;
            City = city;
            Pupil = pupil;
        }
    public string Name { get; set; }
    public string City { get; set; }
    public int Pupil { get; set; }
    }
}
