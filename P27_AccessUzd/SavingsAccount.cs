using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccessUzd
{
    internal class SavingsAccount : BankAccount
    {
        private decimal InterestRate { get; set; }
        public void CalculateInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
