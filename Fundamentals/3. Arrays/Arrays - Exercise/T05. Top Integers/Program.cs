using System;
using System.Linq;
namespace T05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

            int[] topIntegers = new int[arr.Length];

            int topIntegersIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= currentNumber)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex++] = currentNumber;
                }

            }
            for (int i = 0; i < topIntegersIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }
           
        }
    }
}
