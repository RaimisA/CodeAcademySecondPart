using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_ProjectFallout
{
    internal class WeaponItem : InventoryItem
    {
        public WeaponItem()
        {
        }
        public WeaponItem(string name, double weight, int damage, int range)
        {
            Damage = damage;
            Range = range;
            Name = name;
            Weight = weight;
        }
        internal int Damage { get; set; }
        internal int Range { get; set; }
        public override void ParseCsv(string csvLine)
        {
            var parts = csvLine.Split(',');
            if (parts.Length == 4)
            {
                Name = parts[0].Trim();
                Weight = double.Parse(parts[1].Trim().Replace("kg", ""), CultureInfo.InvariantCulture);
                Damage = int.Parse(parts[2].Trim());
                Range = int.Parse(parts[3].Trim());
            }
  
        }
        public override string ToString()
        {
            return $"{Name},{Weight.ToString(CultureInfo.InvariantCulture)}kg,{Damage},{Range}";
        }
    }
}
