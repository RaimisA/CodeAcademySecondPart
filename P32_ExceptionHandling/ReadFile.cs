using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace P32_ExceptionHandling
{
    internal class ReadFile
    {
        private readonly string _fileName;

        internal void ReadFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (SecurityException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
