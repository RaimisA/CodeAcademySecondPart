using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_Streams
{
    public class Smalsumas
    {
        public void OptimizacijosUzdavinys(string path, int samples)
        {
            var timer = new Stopwatch();
            Console.WriteLine("Tikriname File.ReadAllLines efektyvumą");
            timer.Start();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readAllLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadAllLines užtruko: {readAllLinesTime} ms");

            Console.WriteLine($"Tikriname File.ReadLines efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(path);
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadLines užtruko: {readLinesTime} ms");

            Console.WriteLine("Tikriname file.ReadLines kartu su ToArray() efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(path).ToArray();
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readLinesToArrayTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadLines kartu su ToArray() užtruko: {readLinesToArrayTime} ms");

            Console.WriteLine("Tikriname File.ReadAllText o po to split efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadAllText(path).Split('\n');
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readAllTextTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadAllText o po to split užtruko: {readAllTextTime} ms");
        }
    }
}
