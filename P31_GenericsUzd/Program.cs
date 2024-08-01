namespace P31_GenericsUzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 - 2
            //Validation.Validate<string>(null);
            #endregion

            #region 3
            Console.WriteLine("3uzd-------------------------");
            ShowValues<string, DateTime>("Labas vakaras", DateTime.Now);
            Console.WriteLine("------------------------------");
            ShowValues <double, bool>(0.1, true);
            Console.WriteLine("------------------------------");
            #endregion
            #region 4
            Console.WriteLine();
            Console.WriteLine("4uzd-------------------------");
            var myList = new MySelfCreatedList<string>();
            myList.AddElement("Pirmas");
            myList.AddElement("Antras");
            myList.AddElement("Trecias");
            myList.Print();

            Console.WriteLine("Print po delete: ");
            myList.DeleteElement("Antras");
            myList.Print();
            Console.WriteLine("------------------------------");
            #endregion

            #region Uzd2
            var figure = new FourSideGeometricFigure();
            figure.Name = "Kvadratas";
            figure.Base = 5;
            figure.Height = 5;
            var generator = new Generator<FourSideGeometricFigure>();
            generator.Show(figure);
            #endregion
        }
        public static void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine($"{value1} {value2}");
        }
    }
}
