using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccessUzd
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public string GetSubject() { return Subject; }
    }
}
