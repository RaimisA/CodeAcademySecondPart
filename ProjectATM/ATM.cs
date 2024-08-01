using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectATM
{
    public class ATM
    {
        private readonly IUserService _userService;
        private readonly ITransaction _transaction;
        private readonly Menu _menu;

        public ATM(IUserService userService, ITransaction transaction, Menu menu)
        {
            _userService = userService;
            _transaction = transaction;
            _menu = menu;
        }

        public void Start()
        {
            Console.WriteLine("Please insert your card (enter card ID):");
            string cardID = Console.ReadLine();

            if (_userService.IsCardValid(cardID))
            {
                _transaction.SetCurrentCardId(cardID);
                Console.Clear();
                int attemptCount = 3;
                while (attemptCount > 0)
                {
                    Console.WriteLine("Please enter your password:");
                    string password = Console.ReadLine();
                    Console.Clear();

                    if (_userService.Authenticate(password))
                    {
                        Console.WriteLine($"Login successful. Your balance is {_userService.Balance} eur.");
                        _menu.ShowMenu();
                        return;
                    }
                    else
                    {
                        attemptCount--;
                        if (attemptCount > 0)
                        {
                            Console.WriteLine($"Incorrect password. Attempts left {attemptCount}");
                        }
                        else
                        {
                            Console.WriteLine("Too many incorrect attempts. Card rejected.");
                            return;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid card.");
            }
        }
    }
}
