namespace P25_InheritanceUzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Uzduotis
            //var car = new Car(100);
            //Console.WriteLine("Car speed {0}", car.Speed);

            //var bike = new Bike(20);
            //Console.WriteLine("Bike speed {0}", bike.Speed);

            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee("Jonas", 1000),
            //    new Employee("Petras", 2000),
            //    new Employee("Antanas", 3000)
            //};
            //var manager = new Manager("Jonas", 1000,employees);
            //manager.PrintInfo();
            #endregion
           
            #region 2.1 Uzduotis
            var food = new Food("Duona", 1.5);
            Console.WriteLine($"Preke: {food.Name} kainuoja: {food.Price} euro, o jos galiojimas baigiasi {food.ExpirationTime} ");
            #endregion
            #region 2.2 Uzduotis
            var electronics = new Electronics("Televizorius", 500);
            Console.WriteLine($"Preke: {electronics.Name} kainuoja: {electronics.Price} euro, o garantija baigiasi {electronics.Warranty} ");
            #endregion
            #region 2.3 Uzduotis

            #endregion
            #region 3.1 Uzduotis
            var transport = new Transport();
            Console.WriteLine("Transport speed {0}", transport.MeasureSpeed());
            var car = new Car(100);
            Console.WriteLine("Car speed {0}", car.MeasureSpeed());
            #endregion
            #region 3.2 Uzduotis
            var employee = new Employee();
            Console.WriteLine(employee.Greeting());
            #endregion
            #region 3.3 Uzduotis
            var manager = new Manager();
            Console.WriteLine(manager.Greeting());
            #endregion
            #region 4.1 Uzduotis
            var rectangle = new Rectangle(10, 20);
            rectangle.Draw();
            var circle = new Circle(5);
            circle.Draw();
            #endregion


        }
    }
}
