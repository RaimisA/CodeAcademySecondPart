using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace P29_SteamsUzd
{
    public class WorkWithFiles
    {
        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        public void WriteAllLines(string filePath, List<string> lines)
        {
            File.WriteAllLines(filePath, lines);
        }
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
        public void SupratimoUzduotis1(string path)
        {
            string[] lines = new string[] { "Labas", "rytas", "blogai", "labas", "miegas" };
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    writer.Write(line);
                }
            }

        }
        

        public void SupratimoUzduotis2(string path)
        {
            string tekstas = "orem ipsum dolor site ame\r\n" +
                "consectetur adipiscing elit\r\n" +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua\r\n" +
                "Ut enim ad minim veniam\r\n" +
                "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat\r\n" +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur\r\n" +
                "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
            File.WriteAllText("example.txt", tekstas);
        }

        public void SupratimoUzduotis3(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string content = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(content);
            }
        }
        public string ReadFileContent(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
