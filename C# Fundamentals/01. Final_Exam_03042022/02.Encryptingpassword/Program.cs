using System;
using System.Text.RegularExpressions;

namespace E02.Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern 
                = @"(.+)>[0-9]{3}\|[a-z]{3}\|[A-Z]{3}\|[^\<\>]{3}<\1";
            string patternForDecrypt
                = @"(?<number>[0-9]{3})\|(?<lower>[a-z]{3})\|(?<UPPER>[A-Z]{3})\|(?<symbol>[^\<\>]{3})";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currPassword = Console.ReadLine();
              
                Match match = Regex.Match(currPassword, pattern);

                if (match.Success)
                {
                    Match decrypted = Regex.Match(currPassword, patternForDecrypt);

                    string number = (string)decrypted.Groups["number"].Value;
                    string lower = (string)decrypted.Groups["lower"].Value;
                    string upper = (string)decrypted.Groups["UPPER"].Value;
                    string symbol = (string)decrypted.Groups["symbol"].Value;

                    string validPassword = number + lower + upper + symbol;

                    Console.WriteLine($"Password: {validPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}