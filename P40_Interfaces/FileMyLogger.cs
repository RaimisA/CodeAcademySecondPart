using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40_Interfaces
{
    internal class FileMyLogger : IMyLogger
    {
        private readonly string _fileName;
        public FileMyLogger(string fileName)
        {
            _fileName = fileName;
        }
        public void Log(string message)
        {
            try
            {
                File.AppendAllText(_fileName, $"{DateTime.Now} {message}{Environment.NewLine}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }            
        }
    }
}
