namespace P29_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Streams!");
            var darbasSuFailais = new DarbasSuFailais();
            //var filePath = "tekstas.txt"; //!!!!!!!
            //var text = darbasSuFailais.ReadAllText(filePath);
            //Console.WriteLine(text);
            //var filePath2 = "tekstas2.txt";
            //var newText = "naujas tekstas";
            //darbasSuFailais.WriteAllText(filePath2, newText);

            //var text2 = darbasSuFailais.ReadAllText(filePath2);
            //Console.WriteLine(text2);

            var pathToGyvunai = "C:\\Users\\raimo\\Source\\Repos\\CodeAcademySecondPart\\P29_Streams\\guvunai.txt"; //!!!!!!!
            string[] gyvunai = darbasSuFailais.ReadAllLines(pathToGyvunai);
            foreach (var gyvunas in gyvunai)
            {
                Console.WriteLine($"gyvunas yra - {gyvunas}");
            }

            string[] naujiGyvunai = ["Kate", "Suo", "Eziukas"];
            darbasSuFailais.WriteAllLines(pathToGyvunai, naujiGyvunai); //perrasome faila
            var papuga = "Papuga";
            naujiGyvunai = naujiGyvunai.Concat(new string[] { papuga }).ToArray();
            darbasSuFailais.WriteAllLines(pathToGyvunai, naujiGyvunai); //papildome faila

            Console.WriteLine("pres any key to continue");
            Console.ReadKey();
        }
    }
}
