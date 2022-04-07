using System;

namespace L05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();

            string resultWord = string.Empty;
            string resultNumber = string.Empty;
            string resultSymbol = string.Empty;

            foreach (var chars in line)
            {
                if (char.IsDigit(chars))
                {
                    resultNumber += chars;
                }
                else if (char.IsLetter(chars))
                {
                    resultWord += chars;
                }
                else
                {
                    resultSymbol += chars;
                }
            }
            Console.WriteLine(resultNumber);
            Console.WriteLine(resultWord);
            Console.WriteLine(resultSymbol);
        }
    }
}
