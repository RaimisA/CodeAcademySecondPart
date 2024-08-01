using System.Globalization;

namespace P32_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.1 uzd
            //var value = 'a';
            ////var value = true;
            ////var value = DateTime.Now;
            ////var value = "145.5";
            ////var value = "145,6";
            //try
            //{
            //    double doubleValue = Convert.ToDouble(value);
            //    Console.WriteLine($"Convert string {value} to double {doubleValue}.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"{ex.Message}");
            //}
            #endregion
            #region 2.1 uzd
            //int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //try
            //{
            //    Console.WriteLine(arr[7]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region 3.1 uzd
            //int[] arr = { 19, 0, 75, 52 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine(arr[i] / arr[i + 1]);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine($"{ex.Message}");
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"{ex.Message}");
            //    }
            //    catch (OverflowException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            #endregion
            #region 4.1 uzd
            //var readFile = new ReadFile();
            //readFile.ReadFromFile("");
            //readFile.ReadFromFile("..\\..\\..\\test.txt");
            //readFile.ReadFromFile("..\\..\\..\\..\\test.txt");
            //readFile.ReadFromFile("G:\\test.txt");
            //readFile.ReadFromFile("C:\\ttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttettesttesttesttesttesttesttesttesttesttesttestttesttesttesttesttesttesttesttesttesttesttestttesttesttesttesttesttesttesttesttesttestteststtesttestttesttesttesttesttesttesttesttesttesttesttestttesttesttesttesttesttesttesttesttesttesttest.txt");
            //readFile.ReadFromFile(null);
            #endregion
        }
    }
}
