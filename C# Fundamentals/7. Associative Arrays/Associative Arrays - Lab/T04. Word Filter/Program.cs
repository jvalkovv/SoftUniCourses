using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ')
                .Where(w => w.Length % 2 ==0)
                .ToArray();

            foreach (var item in array)
            {
                Console.WriteLine(item);            
            }

        }
    }
}
