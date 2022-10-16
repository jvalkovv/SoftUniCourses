using System;
using System.Collections.Generic;
using System.Linq;


namespace E01._The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MONTH = 30;

            double countOfBiscuitProducedPerDay = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double competingOfBiscuitPerMonth = double.Parse(Console.ReadLine());
            double biscuiteForMonth = 0;

            for (int day = 1; day <= MONTH; day++)
            {
                if (day % 3 == 0)
                {
                    biscuiteForMonth += Math.Floor((countOfBiscuitProducedPerDay * 0.75) * countOfWorkers);
                }
                else
                {
                    biscuiteForMonth += countOfWorkers * countOfBiscuitProducedPerDay;
                }
            }
            Console.WriteLine($"You have produced {biscuiteForMonth} biscuits for the past month.");

            double diff = biscuiteForMonth - competingOfBiscuitPerMonth;
            double percent = Math.Abs(diff / competingOfBiscuitPerMonth * 100);

            if (biscuiteForMonth > competingOfBiscuitPerMonth)
            {
               
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }
            else if(biscuiteForMonth < competingOfBiscuitPerMonth)
            {  
                Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
            }

        }
    }
}
