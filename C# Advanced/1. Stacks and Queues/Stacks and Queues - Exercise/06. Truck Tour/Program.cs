using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfFuel = int.Parse(Console.ReadLine());
            Queue<string> result = new Queue<string>();

            for (int i = 0; i < countOfFuel; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                result.Enqueue(input);
            }
            int totalFuel = 0;

            for (int i = 0; i < countOfFuel; i++)
            {
                string currentInfo = result.Dequeue();
                var info = currentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];

                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }
                result.Enqueue(currentInfo);
            }
            var firstElement = result.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}
