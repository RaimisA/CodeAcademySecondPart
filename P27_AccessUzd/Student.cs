using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccessUzd
{
    internal class Student : Person
    {
        private int StudentId { get; set; }

        public int GetAge() { return age; }
        public void SetAge(int value) { age = value; }
        public int GetStudentId() { return StudentId; }

        public void PrintStudentInfo()
        {
            PrintInfo();
            Console.WriteLine(GetStudentId());
        }
    }
}
