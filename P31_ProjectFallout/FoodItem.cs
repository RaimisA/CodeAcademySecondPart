using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_ProjectFallout
{
    internal class FoodItem : InventoryItem
    {
        internal DateTime ExpirationDate { get; set; }
        internal double Calories { get; set; }
        public FoodItem()
        {
        }
        public FoodItem(string name, double weight, double calories, DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
            Calories = calories;
            Name = name;
            Weight = weight;
        }

        public override void ParseCsv(string csvLine)
        {
            var parts = csvLine.Split(',');
            if (parts.Length == 4)
            {
                Name = parts[0].Trim();
                Weight = double.Parse(parts[1].Trim().Replace("kg", ""), CultureInfo.InvariantCulture);
                Calories = double.Parse(parts[2].Trim().Replace("kcal", ""), CultureInfo.InvariantCulture);
                ExpirationDate = DateTime.Parse(parts[3].Trim(), CultureInfo.InvariantCulture);
            }  
        }
        public override string ToString()
        {
            return $"{Name},{Weight.ToString(CultureInfo.InvariantCulture)}kg,{Calories}kcal,{ExpirationDate}";
        }
    }
}
