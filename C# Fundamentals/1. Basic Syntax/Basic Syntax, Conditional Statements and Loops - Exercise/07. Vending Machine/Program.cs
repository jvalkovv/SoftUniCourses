using System;


namespace _07.Vending_Machine
{
    class Program
    {
        const double NUTS = 2.00;
        const double WATER = 0.7;
        const double CRISPS = 1.5;
        const double SODA = 0.8;
        const double COKE = 1.0;

        static void Main(string[] args)
        {

            string input = string.Empty;
            string product = string.Empty;
            double coinSum = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);

                if (coins == 0.10 || coins == 0.20 || coins == 0.50 || coins == 1.00 || coins == 2.00)

                {
                    coinSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    if (coinSum < NUTS)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        continue;
                    }

                    coinSum -= NUTS;
                    Console.WriteLine($"Purchased {product.ToLower()}");

                }
                else if (product == "Water")
                {
                    if (coinSum < WATER)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        continue;
                    }

                    coinSum -= WATER;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Crisps")
                {

                    if (coinSum < CRISPS)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        continue;
                    }

                    coinSum -= CRISPS;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Soda")
                {
                    if (coinSum < SODA)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        continue;
                    }

                    coinSum -= SODA;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (product == "Coke")
                {

                    if (coinSum < COKE)
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        continue;
                    }

                    coinSum -= COKE;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
