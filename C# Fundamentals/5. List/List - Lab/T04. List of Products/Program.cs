using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfProduct = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < countOfProduct; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i +1}.{products[i]}");
            }
        }
    }
}
