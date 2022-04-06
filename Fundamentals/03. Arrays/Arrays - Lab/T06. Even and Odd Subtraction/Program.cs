using System;
using System.Linq;
namespace T06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sumOfEven = 0;
            int sumOfOdd = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                if (currNumber % 2 == 0)
                {
                    sumOfEven +=currNumber;
                }
                else
                {
                    sumOfOdd += currNumber;
                }

                result = sumOfEven - sumOfOdd;
            }

            Console.WriteLine(result);
        }
    }
}
