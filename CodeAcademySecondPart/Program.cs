using System.Runtime.InteropServices;

namespace OOPFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer
            {
                Name = "Samsung",
                RAM = 16,
                CPU = "Intel",
                GraphicCard = "NVIDIA Geforce 3070",
                BuildDate = new DateTime(2020, 10, 3),
                HasFloppy = false // Assuming you add this property based on your Computer class definition
            };

            // Assuming Computer class has been modified to include a constructor that accepts parameters
            Computer computer2 = new Computer("ASUS", "AMD Radeon", "AMD", 8, true);

            // Create a list of computers
            List<Computer> computers = new List<Computer> { computer, computer2 };

            foreach (Computer comp in computers)
            {
                comp.PrintInfo();
                string isEnough = comp.IsEnoughRam();
                Console.WriteLine(isEnough);
            }
        }
    }
}
