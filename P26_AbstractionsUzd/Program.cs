namespace P26_AbstractionsUzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region uzduotis 1.2
            List<GeometricShape> shapes = new List<GeometricShape>();
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Square(5));
            shapes.Add(new Triangle(6, 8, 10));
            shapes.Add(new Square(7));
            shapes.Add(new Triangle(9, 12, 15));
            shapes.Add(new Square(9));
            shapes.Add(new Triangle(12, 16, 20));
            shapes.Add(new Square(11));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
                Console.WriteLine(shape.GetPerimeter());
                Console.WriteLine();
            }
            #endregion
            #region uzduotis 2.1
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Truck("Volvo", "FH16", 2021, 25));
            vehicles.Add(new Bus("Mercedes-Benz", "Tourismo", 2021, 50));
            vehicles.Add(new Scooter("Xiaomi", "Mi Electric Scooter 1S", 2021, true));
            vehicles.Add(new Truck("Scania", "R730", 2021, 30));
            vehicles.Add(new Bus("Setra", "S 431 DT", 2021, 60));
            vehicles.Add(new Scooter("Segway", "Ninebot KickScooter MAX G30", 2021, true));

            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayVehicleInfo();
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            #endregion
            #region uzduotis 2.2
            
            #endregion
        }
    }
}
