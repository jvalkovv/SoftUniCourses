using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> result = new Stack<int>(numbers);

            while (result.Count > 0)
            {
                Console.Write($"{result.Pop()} ");
            }
        }
    }
}
