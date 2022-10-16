using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace E01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern =
       @">>(?<furniture>[A-z]+)<<(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";
            List<string> buyedItems = new List<string>();

            double sum = 0;
            string cmd;

            while ((cmd = Console.ReadLine()) != "Purchase")
            {
                Match collection = Regex.Match(cmd, pattern);

                if (collection.Success)
                {
                    var furniture = collection.Groups["furniture"].Value;
                    var price = collection.Groups["price"].Value;
                    var quantity = collection.Groups["quantity"].Value;

                    buyedItems.Add(furniture);

                    double priceDecimal = double.Parse(price);
                    int qtyOfFurnt = int.Parse(quantity);
                    sum += priceDecimal * qtyOfFurnt;
                }
            }
            PrintResult(buyedItems, sum);
        }
        static void PrintResult(List<string> names, double price)
        {

            Console.WriteLine("Bought furniture:");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }

}
