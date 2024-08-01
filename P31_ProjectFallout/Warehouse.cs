using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_ProjectFallout
{
    internal class Warehouse<T> where T : InventoryItem
    {
        internal void AddItem(T item)
        {
            string fileName = GetFileNameBasedOnType();
            if (!string.IsNullOrEmpty(fileName))
            {
                File.AppendAllLines(fileName, new string[] { item.ToString() });
            }
            else
            {
                throw new InvalidOperationException("Unsupported item type.");
            }
        }

        internal List<T> GetItems()
        {
            List<T> items = new List<T>();
            string fileName = GetFileNameBasedOnType();
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    T item = (T)Activator.CreateInstance(typeof(T));
                    item.ParseCsv(line);
                    items.Add(item);
                }
            }
            else
            {
                throw new InvalidOperationException("Unsupported item type.");
            }
            return items;
        }
        internal T GetItem(string name)
        {
            string fileName = GetFileNameBasedOnType();
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    T item = (T)Activator.CreateInstance(typeof(T));
                    item.ParseCsv(line);
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Unsupported item type.");
            }
            return default(T);
        }

        private string GetFileNameBasedOnType()
        {
            if (typeof(T) == typeof(FoodItem))
            {
                return "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P31_ProjectFallout\\food.csv";
            }
            else if (typeof(T) == typeof(MedicalItem))
            {
                return "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P31_ProjectFallout\\medicine.csv";
            }
            else if (typeof(T) == typeof(WeaponItem))
            {
                return "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P31_ProjectFallout\\weapons.csv";
            }
            return null;
        }
    }
}
