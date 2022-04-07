using System;
using System.Collections.Generic;
using System.Linq;

namespace E03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRating = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int cnt = 0; cnt < entryPoint; cnt++)
            {
                if (typeOfItems == "cheap")
                {
                    if (priceRating[entryPoint] > priceRating[cnt])
                    {
                        left.Add(priceRating[cnt]);
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (priceRating[entryPoint] <= priceRating[cnt])
                    {
                        left.Add(priceRating[cnt]);
                    }
                }
            }
            for (int cnt = entryPoint +1; cnt < priceRating.Count; cnt++)
            { 
                if (typeOfItems == "cheap")
                {

                    if (priceRating[entryPoint] > priceRating[cnt])
                    {
                        right.Add(priceRating[cnt]);
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (priceRating[entryPoint] <= priceRating[cnt])
                    {
                        right.Add(priceRating[cnt]);
                    }
                }
            }
            if (left.Sum() == right.Sum())
            {
                Console.WriteLine($"Left - {left.Sum()}");
            }
            else if (left.Sum() < right.Sum())
            {
                Console.WriteLine($"Right - {right.Sum()}");
            }
            else
            {
                Console.WriteLine($"Left - {left.Sum()}");
            }
        }
    }
}
