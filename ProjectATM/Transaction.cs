using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectATM
{
    public class Transaction : ITransaction
    {
        private readonly string _transactionFilePath;
        private readonly string _cardInfoFilePath;
        private readonly BillManager _billManager;
        private string _currentCardId;

        public Transaction(string transactionFilePath, string billsFilePath, string cardInfoFilePath)
        {
            _transactionFilePath = transactionFilePath;
            _cardInfoFilePath = cardInfoFilePath;
            _billManager = new BillManager(billsFilePath);
            _currentCardId = string.Empty;
        }

        public void SetCurrentCardId(string cardId)
        {
            _currentCardId = cardId;
        }

        public void RecordTransaction(decimal amount)
        {
            try
            {
                File.AppendAllText(_transactionFilePath, $"Card number: {_currentCardId}, Transaction Date: {DateTime.Now}, Withdrawn amount: {amount}{Environment.NewLine}");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"An I/O error occurred while recording the transaction: {ioEx.Message}");
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine($"You do not have permission to write to the file: {uaEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public void ShowLastFiveTransactions()
        {
            if (File.Exists(_transactionFilePath))
            {
                var transactions = File.ReadLines(_transactionFilePath)
                    .Where(line => line.Contains($"Card number: {_currentCardId},"))
                    .Reverse()
                    .Take(5)
                    .ToList();
                Console.WriteLine("Last five transactions: ");
                transactions.ForEach(transaction => Console.WriteLine(transaction));
            }
            else
            {
                Console.WriteLine("No transactions found.");
            }
        }

        public void WithdrawMoney(IUserService user)
        {
            try
            {
                if (!_billManager.AreBillsAvailable())
                {
                    Console.Clear();
                    Console.WriteLine("No bills available for withdrawal.");
                    return;
                }

                if (GetTodaysWithdrawalCount() >= 10)
                {
                    Console.Clear();
                    Console.WriteLine("You have reached the maximum number of withdrawals for today.");
                    return;
                }

                Console.WriteLine($"Enter amount to withdraw (max 1000 eur) (Balance: {user.Balance}):");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                {
                    if (amount <= 1000 && amount <= user.Balance)
                    {
                        var billsToDispense = _billManager.GetBillsToDispense(amount);
                        if (billsToDispense != null)
                        {
                            user.UpdateBalance(user.Balance - amount);
                            _billManager.UpdateBills(billsToDispense);
                            RecordTransaction(amount);
                            UpdateCardInfoBalance(user.Balance);
                            Console.Clear();
                            Console.WriteLine($"Withdrawal successful. New balance is {user.Balance} eur.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Cannot dispense the requested amount with available bills.");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid amount or insufficient balance.");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        private int GetTodaysWithdrawalCount()
        {
            if (!File.Exists(_transactionFilePath))
            {
                return 0;
            }

            var today = DateTime.Today;
            var transactions = File.ReadLines(_transactionFilePath)
                .Where(line => line.Contains($"Card number: {_currentCardId}, Transaction Date: "))
                .Select(line => DateTime.Parse(line.Split(new[] { "Transaction Date: " }, StringSplitOptions.None)[1].Split(',')[0]))
                .Count(date => date.Date == today);

            return transactions;
        }

        private void UpdateCardInfoBalance(decimal newBalance)
        {
            try
            {
                var lines = File.ReadAllLines(_cardInfoFilePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(',');
                    if (parts[0] == _currentCardId)
                    {
                        lines[i] = $"{_currentCardId},{parts[1]},{newBalance}";
                        break;
                    }
                }
                File.WriteAllLines(_cardInfoFilePath, lines);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"An I/O error occurred while updating the balance: {ioEx.Message}");
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine($"You do not have permission to write to the file: {uaEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
