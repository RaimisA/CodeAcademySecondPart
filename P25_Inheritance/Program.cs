namespace P25_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Paveldėjimas!");
            #region ***** Terminija *****

            /*
             - Inheritance (Paveldėjimas): Procesas, kuriuo viena klasė perima kitos klasės atributus ir operacijas.
             - Base Class (Bazinė klasė): Klasė, iš kurios paveldima. Taip pat žinoma kaip superclass, arba tėvinė klasė.
             - Derived Class (Paveldėta klasė): Klasė, kuri paveldi iš bazinės klasės. Taip pat žinoma kaip subclass arba child class.
             - Method Overriding (Metodų parrašymas): Paveldėtoje klasėje perrašytas bazinės klasės metodas, naudojant override raktinį žodį.
             - Method Hiding (Metodų slėpimas): Kai paveldėtoje klasėje sukuriamas metodas su tokiu pačiu pavadinimu kaip ir bazinėje klasėje, naudojant new raktinį žodį. Šis metodas slepia bazinės klasės metodą.
             - Virtual Method (Virtualus metodas): Bazinės klasės metodas, pažymėtas virtual raktiniu žodžiu, kuris gali būti perrašytas paveldėtoje klasėje.
             - Calling Base Class Constructors (Bazinių klasių konstruktorių kvietimas): Procesas, kuriuo paveldėtos klasės konstruktorius kviečia bazinės klasės konstruktorių.
             */


            #endregion

            var square = new Square();
            Console.WriteLine("NumberOfAngles {0}", square.NumberofAngles);
            Console.WriteLine("Size {0}", square.Size);

            var polygon = new Polygon(5);
            Console.WriteLine("NumberOfAngles {0}", polygon.NumberofAngles);
            //size nepasiekiamas, nes priklauso vaikui

            var employee = new Employee();
            var human = new Human();
            var entity = new Entity();
        }
    }
}
