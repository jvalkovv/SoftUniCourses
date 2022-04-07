using System;

namespace T09SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStartingSpice = int.Parse(Console.ReadLine());
            int consumeFromWorkers = 26;
            int yieldDrops = 10;
            int counterOfDays = 0;
            int minedSpice = 0;

            while (numberOfStartingSpice >= 100)
            {

                minedSpice += numberOfStartingSpice - consumeFromWorkers;
                numberOfStartingSpice -= yieldDrops;
                counterOfDays++;
            }

            if (minedSpice >= consumeFromWorkers)
            {

                minedSpice -= consumeFromWorkers;
                
            }

            Console.WriteLine(counterOfDays);
            Console.WriteLine(minedSpice);
        }
    }
}
