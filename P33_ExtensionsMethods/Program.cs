namespace P33_ExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////---------Ar teigiama, lyginis, didesnis už 12----------
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter any number: ");
            //        int inputNumber = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"The number is positive: {inputNumber.IsPositive()}");
            //        Console.WriteLine($"The number is even: {inputNumber.IsEven()}");
            //        Console.WriteLine($"The number is greater than 12: {inputNumber.IsGreaterThan(12)}");
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            ////---------Ar turi tarpų----------

            //Console.WriteLine("Enter any text: ");
            //string text = Console.ReadLine();
            //Console.WriteLine($"The text has spaces: {text.HasSpace()}");

            ////-----------------Email----------------
            //Console.WriteLine("Enter your full name: ");
            //string fullName = Console.ReadLine();
            //Console.WriteLine("Enter your year of birth: ");
            //int yearOfBirth = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your domain: ");
            //string domain = Console.ReadLine();
            //Console.WriteLine($"The email is: {fullName.ConvertToEmail(yearOfBirth, domain)}");

            ////-----------------Rasti vienodus--------------
            //List<int> numbers = new() { 10, 11, 22, 45, 12, 22, 55, 22 };
            //List<string> words = new() { "Labas", "Kaip sekasi", "Vakaras", "Poilsis" };

            //Console.WriteLine("Enter a number to find in a list: ");
            //int findValue = int.Parse(Console.ReadLine());


            //List<int> foundNumbers = numbers.FindAndReturnIfEqual(findValue);

            //Console.WriteLine("Found numbers: ");
            //foreach (int number in foundNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Enter a word to find in a list: ");
            //string findWord = Console.ReadLine();

            //List<string> foundWords = words.FindAndReturnIfEqual(findWord);
            //Console.WriteLine("Found words: ");
            //foreach (string word in foundWords)
            //{
            //    Console.WriteLine(word);
            //}

            ////-----------------Rasti kas antra--------------

            //List<int> everyOtherNumber = numbers.EveryOtherWord();
            //Console.WriteLine("Every other number: ");
            //foreach (int number in everyOtherNumber)
            //{
            //    Console.WriteLine(number);
            //}

            //List<string> everyOtherWord = words.EveryOtherWord();
            //Console.WriteLine("Every other word: ");
            //foreach (string word in everyOtherWord)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
