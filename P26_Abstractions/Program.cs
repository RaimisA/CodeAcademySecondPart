namespace P26_Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var txtDocument = new TxtDocument("tekstas.txt", "TestFile");

            txtDocument.Write("Tekstas kazkoks");
            Console.WriteLine();

            var pdfDocument = new PdfDocument("saskaita.pdf", "Saskaita", true);

            pdfDocument.Write("saskaita pinigai pinigai");
            Console.WriteLine();

            var wordDocument = new WordDocument("sutartis.docx", "sutartis");

            wordDocument.Write("sutartis bauda bauda");
            Console.WriteLine();

            List<Document> documents = new List<Document>();
            documents.Add(txtDocument);
            documents.Add(pdfDocument);
            documents.Add(wordDocument);

            

            foreach (var document in documents)
            {
                var content = document.Read();
                Console.WriteLine($"{document.Title}: \n {content}");
                Console.WriteLine();
                
                if (document is PdfDocument pdf) //optional ir nedaznai naudojamas
                {
                    Console.WriteLine($"Ar yra pasirasytas: {pdf.IsSigned}");
                }
            }
        }
    }
}
