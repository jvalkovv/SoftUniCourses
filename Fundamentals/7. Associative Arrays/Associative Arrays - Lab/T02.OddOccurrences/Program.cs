using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string line in array)
            {
                string inLowerCase = line.ToLower();

                if (counts.ContainsKey(inLowerCase))
                {
                    counts[inLowerCase] += 1;
                }
                else
                {
                    counts.Add(inLowerCase, 1);
                }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
