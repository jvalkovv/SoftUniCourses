using System;
using System.Linq;
namespace T07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int count = 1;
            int dublicate = 0;
            int index = arr[0];
            int best = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (index==arr[i])
                {
                    count++;
                }
                else
                {
                    index = arr[i];
                    count = 1;
                }
                if (count > best)
                {
                    best = count;
                    dublicate = arr[i];
                }
            }
            for (int i = 0; i < best; i++)
            {
                Console.Write($"{dublicate} ");
            }
        }
    }
}
