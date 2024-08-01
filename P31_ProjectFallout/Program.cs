using System.Threading.Channels;

namespace P31_ProjectFallout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foodItems
            //var warehouseFood = new Warehouse<FoodItem>();
            //var foodItems = new List<FoodItem>
            //{
            //    new FoodItem("Canned Beans", 0.4, 100, DateTime.Now.AddYears(7)),
            //    new FoodItem("Sugar Bomb", 1, 1000, DateTime.Now.AddYears(50)),
            //    new FoodItem("Nuka cola", 0.33, 500, DateTime.Now.AddYears(1000))
            //};

            //foreach (var item in foodItems)
            //{
            //    warehouseFood.AddItem(item);
            //}

            //var warehouseFood = new Warehouse<FoodItem>();
            //var foodItems = warehouseFood.GetItems();
            //foreach (var foodItem in foodItems)
            //{
            //    Console.WriteLine($"Item name: {foodItem.Name} - weight: {foodItem.Weight} has {foodItem.Calories} calories and expires in {foodItem.ExpirationDate}");
            //}

            //var foodWarehouse = new Warehouse<FoodItem>();
            //var foodItems = foodWarehouse.GetItems();

            //foreach (var foodItem in foodItems)
            //{
            //    Console.WriteLine($"Item name: {foodItem.Name} - weight: {foodItem.Weight} has {foodItem.Calories} calories and expires in {foodItem.ExpirationDate}");
            //}

            //var foodWarehouse = new Warehouse<FoodItem>();
            //var foodItems = foodWarehouse.GetItem("Canned Beans");
            //Console.WriteLine(foodItems);
            #endregion
            #region medicineItems
            var warehouseMedicine = new Warehouse<MedicalItem>();
            var medicineItems = new List<MedicalItem>
            {
                new MedicalItem("Stimpack", 0.2, new List<string> { "Bleeding", "Poisoning" }, DateTime.Now.AddYears(5)),
                new MedicalItem("Radaway", 0.1, new List<string> { "Radiation" }, DateTime.Now.AddYears(10)),
                new MedicalItem("Med-X", 0.3, new List<string> { "Bleeding", "Poisoning" }, DateTime.Now.AddYears(3))
            };

            foreach (var item in medicineItems)
            {
                warehouseMedicine.AddItem(item);
            }
            foreach (var medicineItem in medicineItems)
            {
                Console.WriteLine($"Item name: {medicineItem.Name} - weight: {medicineItem.Weight} cures: {string.Join(", ", medicineItem.IllnessCured)} illnesses and expires in {medicineItem.ExpirationDate}");
            }
            //var warehouseMedicine = new Warehouse<MedicalItem>();
            //var medicineWarehouseItem = warehouseMedicine.GetItem("Stimpack");
            //Console.WriteLine(medicineWarehouseItem);

            #endregion
            #region weaponItems
            //var warehouseWeapons = new Warehouse<WeaponItem>();
            //var weaponItems = new List<WeaponItem>
            //{
            //    new WeaponItem("Pipe Pistol", 2.5, 10, 50),
            //    new WeaponItem("Laser Rifle", 5, 50, 100),
            //    new WeaponItem("Fat Man", 20, 1000, 500)
            //};
            //foreach (var item in weaponItems)
            //{
            //    warehouseWeapons.AddItem(item);
            //}
            //var weaponWarehouse = new Warehouse<WeaponItem>();
            //var weaponItems = weaponWarehouse.GetItems();
            //foreach (var weaponItem in weaponItems)
            //{
            //    Console.WriteLine($"Item name: {weaponItem.Name} - weight: {weaponItem.Weight} kg, does {weaponItem.Damage} damage and has a range of {weaponItem.Range} meters");
            //}
            //var weaponWarehouseItem = weaponWarehouse.GetItem("Fat Man");
            //Console.WriteLine(weaponWarehouseItem);
            #endregion
        }
    }
}
