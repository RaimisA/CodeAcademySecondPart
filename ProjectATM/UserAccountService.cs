using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectATM
{
    public class UserAccountService : IUserService
    {
        private readonly string _cardInfoFilePath;
        private string _currentCardId = string.Empty;
        private decimal _balance;

        public UserAccountService(string cardInfoFilePath)
        {
            _cardInfoFilePath = cardInfoFilePath;
        }

        public bool IsCardValid(string cardId)
        {
            var lines = File.ReadAllLines(_cardInfoFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == cardId)
                {
                    _currentCardId = cardId;
                    _balance = decimal.Parse(parts[2]);
                    return true;
                }
            }
            return false;
        }

        public bool Authenticate(string password)
        {
            var lines = File.ReadAllLines(_cardInfoFilePath);
            return lines
                .Select(line => line.Split(','))
                .Any(parts => parts[0] == _currentCardId && parts[1] == password);
        }

        public decimal Balance => _balance;

        public void UpdateBalance(decimal newBalance)
        {
            _balance = newBalance;
            UpdateCardInfoBalance(_currentCardId, newBalance);
        }

        private void UpdateCardInfoBalance(string cardId, decimal newBalance)
        {
            var lines = File.ReadAllLines(_cardInfoFilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts[0] == cardId)
                {
                    lines[i] = $"{cardId},{parts[1]},{newBalance}";
                    break;
                }
            }
            File.WriteAllLines(_cardInfoFilePath, lines);
        }
    }
}
