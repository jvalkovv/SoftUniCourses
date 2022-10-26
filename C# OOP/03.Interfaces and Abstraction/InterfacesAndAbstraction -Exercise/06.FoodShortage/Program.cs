
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            List<int> result = new List<int>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] currLine = Console.ReadLine().Split();

                if (currLine.Length == 4)
                {
                    Citizen citizen = new Citizen(currLine[0], int.Parse(currLine[1]), currLine[2], currLine[3]);
                    citizens.Add(citizen);
                }
                else if (currLine.Length == 3)
                {
                    Rebel rebel = new Rebel(currLine[0], int.Parse(currLine[1]), currLine[2]);
                    rebels.Add(rebel);
                }

            }
            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                foreach (var item in citizens)
                {
                    if (item.name == cmd)
                    {
                        item.BuyFood();
                        result.Add(item.Food);
                    }
                }
                foreach (var item in rebels)
                {
                    if (item.Name == cmd)
                    {
                        item.BuyFood();
                        result.Add(item.Food);

                    }
                }
            }

            Console.WriteLine(result.Sum());


        }
    }
}
