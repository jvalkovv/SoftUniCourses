using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace LP02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);

            string[] array = Regex
                .Matches(input, pattern)
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", array));



        }
    }
}
