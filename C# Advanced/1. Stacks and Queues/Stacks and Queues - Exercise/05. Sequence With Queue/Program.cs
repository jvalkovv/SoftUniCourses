using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Sequence_With_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int count = 50;

            Queue<long> result = new Queue<long>();
            result.Enqueue(number);

            for (int i = 1; i <= count; i++)
            {
                long a = number + 1;
                result.Enqueue(a);
                long b = number * 2 + 1;
                result.Enqueue(b);
                long c = number + 2;
                result.Enqueue(c);
               
                number = result.ElementAtOrDefault(i);
            }
            Console.Write(string.Join(" ", result.Take(50)));
        }
    }
}