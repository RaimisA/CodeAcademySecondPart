namespace P29_SteamsUzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.1
            var workWithFiles = new WorkWithFiles();
            string text = workWithFiles.ReadAllText("C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P29_SteamsUzd\\tekstas.txt");
            Console.WriteLine(text);
            #endregion
            #region 1.2
            var newList = new List<string> 
            { 
                "rytas", 
                "blogai", 
                "labas", 
                "miegas"
            };
            
            Console.WriteLine();
            workWithFiles.WriteAllLines("C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P29_SteamsUzd\\tekstas.txt", newList);
            #endregion
            #region 1.3
            string filePath = "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P29_SteamsUzd\\didelistekstas.txt";
            string[] readLines = workWithFiles.ReadAllLines(filePath);

            foreach (var readLine in readLines)
            {
                int symbolCount = readLine.Length;
                Console.WriteLine($"Eilute: {readLine} turi {symbolCount} simboliu");
            }
            #endregion
        }
    }
}
