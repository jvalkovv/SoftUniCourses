using System;

namespace T10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = Math.Abs(int.Parse(Console.ReadLine()));
            var sumOfEvenDigits=GetSumOfEvenDigits(numbers);
            var sumOfOddDigits = GetSumOfOddDigits(numbers);
            Console.WriteLine(sumOfEvenDigits*sumOfOddDigits);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;

                if (digit%2==0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
