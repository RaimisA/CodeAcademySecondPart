using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_Abstractions
{
    internal class TxtDocument : Document
    {
        public TxtDocument(string filePath, string title) : base(filePath, title)
        {
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitom TXT {Title}");
            return File.ReadAllText(FilePath);
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Rasom TXT: {Title} {content}");
            File.WriteAllText(FilePath, content);
        }
    }
}
