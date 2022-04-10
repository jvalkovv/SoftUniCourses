using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int elToAdd = commands[0];
            int elToRemove = commands[1];
            int elExist = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> result = new Queue<int>();

            bool isExist = false;
            int smallElement = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (result.Count < elToAdd)
                {
                    result.Enqueue(numbers[i]);
                }
                else
                {
                    break;
                }
            }
            if (result.Count >= elToRemove)
            {
                for (int i = 0; i < elToRemove; i++)
                {
                    result.Dequeue();
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result.Contains(elExist))
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                smallElement = result.Min();
            }
            if (isExist == true)
            {
                Console.WriteLine("true");
            }
            if (isExist == false)
            {
                Console.WriteLine(smallElement);
            }
        }
    }
}