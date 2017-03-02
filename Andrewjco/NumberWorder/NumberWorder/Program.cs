using System;

namespace NumberWorder
{
    internal class Program
    {
        public const string Usage =
            "Expects a single numeric parameter. The application prints each character in the number as a word. e.g. numberworder.exe 1234 prints ONETWOTHREEFOUR";

        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(Usage);
                return;
            }

            try
            {
                var numberWordProcessor = new NumberWordProcessor();
                Console.WriteLine(numberWordProcessor.ConvertNumbersToWords(args[0]));
            }
            catch (Exception)
            {
                Console.WriteLine(Usage);
            }
        }
    }
}