using System;
using System.Text.RegularExpressions;
namespace LP01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";
        
             string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regexPattern);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
            Console.WriteLine();
        }
    }
}
