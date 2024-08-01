using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_ProjectFallout
{
    internal class MedicalItem : InventoryItem
    {
        public MedicalItem()
        {
        }
        public MedicalItem(string name, double weight, List<string> illnessCured, DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
            IllnessCured = illnessCured;
            Name = name;
            Weight = weight;
        }
        internal DateTime ExpirationDate { get; set; }
        internal List<string> IllnessCured { get; set; }
        public override void ParseCsv(string line)
        {
            var parts = line.Split(',');
            if (parts.Length >= 4)
            {
                Name = parts[0].Trim();
                Weight = double.Parse(parts[1].Trim().Replace("kg", ""), CultureInfo.InvariantCulture);
                ExpirationDate = DateTime.Parse(parts[2].Trim(), CultureInfo.InvariantCulture);
                IllnessCured = parts.Skip(3).ToList();
            }
       
        }
        public override string ToString()
        {
            var effects = string.Join("; ", IllnessCured);
            return $"{Name},{Weight.ToString(CultureInfo.InvariantCulture)}kg,{ExpirationDate},{effects}";
        }
    }
}
