using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccessUzd
{
    internal class CheckingAccount : BankAccount
    {
        private int OverDraftLimit { get; set; }
        public decimal Withdraw(decimal amount)
        {
            if (amount > 0 && Balance + OverDraftLimit >= amount)
            {
                Balance -= amount;
                return amount;
            }
            return 0;
        }
    }
}
