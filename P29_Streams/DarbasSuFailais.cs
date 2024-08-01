using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_Streams
{
    public class DarbasSuFailais
    {
        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        public void WriteAllText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
        public void WriteAllLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }
        public void GetCurrentDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string subDirectory = "data";
            string fileName = "file.txt";

            // keliu platformu failo kelio kurimas
            string path = Path.Combine(currentDirectory, subDirectory, fileName);

            Console.WriteLine("Combined path: " + path);
            //read file utf8
            string content = File.ReadAllText(path, Encoding.UTF8);
        }
    }
}
