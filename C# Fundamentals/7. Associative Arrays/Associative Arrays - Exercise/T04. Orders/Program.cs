using System;
using System.Linq;
using System.Collections.Generic;

namespace T04._Orders
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();


            string comamnd;

            while ((comamnd = Console.ReadLine()) != "buy")
            {

                string[] lineOfProduct = comamnd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string nameOfProduct = lineOfProduct[0];
                double priceOfProduct = double.Parse(lineOfProduct[1]);
                int quantityOfProduct = int.Parse(lineOfProduct[2]);

                if (!products.ContainsKey(nameOfProduct))
                {

                    products[nameOfProduct] = new List<double>();

                    products[nameOfProduct].Add(priceOfProduct);
                    products[nameOfProduct].Add(quantityOfProduct);

                }
                else if (products.ContainsKey(nameOfProduct))
                {
                    products[nameOfProduct][1] += quantityOfProduct;
                    if (products[nameOfProduct][0] != priceOfProduct)
                    {
                        products[nameOfProduct].RemoveAt(0);
                        products[nameOfProduct].Insert(0, priceOfProduct);
                    }

                }

            }
            foreach (var item in products)
            {
                List<double> priceAndQty = item.Value;
                double price = priceAndQty[0];
                double qty = priceAndQty[1];

                double totalPrice = price * qty;
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }

        }
    }
}
