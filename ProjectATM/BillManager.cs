namespace ProjectATM
{
    public class BillManager
    {
        private readonly string _billsFilePath;
        private readonly Dictionary<decimal, int> _bills;

        public BillManager(string billsFilePath)
        {
            _billsFilePath = billsFilePath;
            _bills = LoadBills();
        }

        public Dictionary<decimal, int> GetBillsToDispense(decimal amount)
        {
            var billsToDispense = new Dictionary<decimal, int>();
            var remainingAmount = amount;

            foreach (var bill in _bills.OrderByDescending(b => b.Key))
            {
                int count = (int)(remainingAmount / bill.Key);
                if (count > 0)
                {
                    int availableCount = Math.Min(count, bill.Value);
                    if (availableCount > 0)
                    {
                        billsToDispense[bill.Key] = availableCount;
                        remainingAmount -= availableCount * bill.Key;
                    }
                }
            }

            return remainingAmount == 0 ? billsToDispense : null;
        }

        public void UpdateBills(Dictionary<decimal, int> billsToDispense)
        {
            billsToDispense.ToList().ForEach(b => _bills[b.Key] -= b.Value);

            SaveBills();
        }

        private Dictionary<decimal, int> LoadBills()
        {
            var loadedBills = new Dictionary<decimal, int>();

            if (File.Exists(_billsFilePath))
            {
                var lines = File.ReadAllLines(_billsFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && decimal.TryParse(parts[0], out decimal denomination) && int.TryParse(parts[1], out int count))
                    {
                        loadedBills[denomination] = count;
                    }
                }
            }

            return loadedBills;
        }

        private void SaveBills()
        {
            var lines = _bills.Select(b => $"{b.Key},{b.Value}");
            File.WriteAllLines(_billsFilePath, lines);
        }

        public bool AreBillsAvailable()
        {
            return _bills.Values.Any(count => count > 0);
        }
    }
}
