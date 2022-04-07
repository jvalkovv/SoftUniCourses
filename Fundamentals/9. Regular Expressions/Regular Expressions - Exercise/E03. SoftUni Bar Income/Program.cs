using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
      @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            double sum = 0;

            string cmd;
            while ((cmd = Console.ReadLine()) != "end of shift")
            {
                if (Regex.IsMatch(cmd, pattern))
                {
                    Match match = Regex.Match(cmd, pattern);
                    var name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * quantity;
                    Console.WriteLine($"{name}: {product} - {money:F2}");
                    sum += money;
                }
            }
            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
