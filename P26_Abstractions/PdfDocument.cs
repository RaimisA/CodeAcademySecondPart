using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_Abstractions
{
    internal class PdfDocument : Document
    {
        public bool IsSigned { get; set; }
        public PdfDocument(string filePath, string title, bool isSigned) : base(filePath, title)
        {
            IsSigned = isSigned;
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitom PDF {Title}");
            return "Skaitom PDF";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Rasom PDF: {Title} {content}");
        }
    }
}
