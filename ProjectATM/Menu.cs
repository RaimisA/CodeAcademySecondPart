using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectATM
{
    public class Menu
    {
        private readonly IUserService _user;
        private readonly ITransaction _transaction;

        public Menu(IUserService user, ITransaction transaction)
        {
            _user = user;
            _transaction = transaction;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. View balance");
                Console.WriteLine("2. View last five transactions");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Your balance is {_user.Balance} eur.");
                        break;
                    case "2":
                        Console.Clear();
                        _transaction.ShowLastFiveTransactions();
                        break;
                    case "3":
                        Console.Clear();
                        _transaction.WithdrawMoney(_user);
                        break;
                    case "4":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
