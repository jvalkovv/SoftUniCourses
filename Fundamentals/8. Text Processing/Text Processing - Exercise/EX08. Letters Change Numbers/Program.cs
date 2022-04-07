using System;
using System.Linq;
using System.Text;

namespace EX08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;

            foreach (var item in input)
            {
                sum += CalculateSingleWordSum(item);
            }
            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];

            int number = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = GetAlphabeticalPosChar(firstLetter);
            int lastLetterPos = GetAlphabeticalPosChar(lastLetter);

            if (Char.IsUpper(firstLetter))
            {
                sum = (decimal)number / firstLetterPos;
            }
            else if (Char.IsLower(firstLetter))
            {
                sum = (decimal)number * firstLetterPos;
            }
            if (Char.IsUpper(lastLetter))
            {
                sum -= lastLetterPos;
            }
            else if (Char.IsLower(lastLetter))
            {
                sum += lastLetterPos;
            }

            return sum;
        }

        static int GetAlphabeticalPosChar(char ch)
        {

            char chCI = char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
