using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P27_AccessUzd
{
    internal class BankAccount
    {
        protected decimal balance;

        protected decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void SetBalance(decimal amount)
        {
            Balance = amount;
        }
       
   
        protected void PrintBalance()
            {
                Console.WriteLine($"Balance: {Balance}");
            }

    }
}
