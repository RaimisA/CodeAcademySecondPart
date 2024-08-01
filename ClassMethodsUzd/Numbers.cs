using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsUzd
{
    internal class Numbers
    {
        List<int> numbers = new List<int>();

        public int AddNumberTolist(int number)
        {
            numbers.Add(number);
            return numbers.Count;
        }
        public void PrintNumbers()
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
   

}
