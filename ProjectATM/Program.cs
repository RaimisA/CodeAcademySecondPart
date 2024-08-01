using System.Net.NetworkInformation;
using System;

namespace ProjectATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardInfoFilePath = "cardInfo.csv";
            string transactionsFilePath = "transactions.csv";
            string billsFilePath = "bills.csv";

            IUserService user = new UserAccountService(cardInfoFilePath);
            ITransaction transaction = new Transaction(transactionsFilePath, billsFilePath, cardInfoFilePath);
            Menu menu = new Menu(user, transaction);
            ATM atm = new ATM(user, transaction, menu);
            atm.Start();
        }
    }
}
