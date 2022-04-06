using System;
using System.Collections.Generic;

namespace T03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string gameToBuy;
            double totalSpent = 0;

            Dictionary<string, double> validGames = new Dictionary<string, double>();
            validGames.Add("OutFall 4", 39.99);
            validGames.Add("CS: OG", 15.99);
            validGames.Add("Zplinter Zell", 19.99);
            validGames.Add("Honored 2", 59.99);
            validGames.Add("RoverWatch", 29.99);
            validGames.Add("RoverWatch Origins Edition", 39.99);

            while ((gameToBuy = Console.ReadLine()) != "Game Time")
            {
                if (!validGames.ContainsKey(gameToBuy))
                {
                    Console.WriteLine($"Not Found");
                }
                else
                {
                    double priceForCurrGame = validGames[gameToBuy];

                    if (balance >= priceForCurrGame)
                    {
                        balance -= priceForCurrGame;
                        totalSpent += priceForCurrGame;
                        Console.WriteLine($"Bought {gameToBuy}");
                    }
                    else
                    {
                        Console.WriteLine($"Too Expensive");
                    }
                    if (balance == 0)
                    {
                        Console.WriteLine($"Out of money!");
                        break;
                    }
                }
            }
            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
