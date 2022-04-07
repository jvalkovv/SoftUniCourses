using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firtList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int longestArray = Math.Max(firtList.Count, secondList.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < longestArray; i++)
            {
                if (firtList.Count > i)
                {
                    result.Add(firtList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
