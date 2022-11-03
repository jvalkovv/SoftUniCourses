using System;

namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int counter = 0;
            int num = 0;
            int[] numbers = new int[10];

            while (counter < 10)
            {
                try
                {
                    num = ReadNumber(start, end);
                    start = num;
                    numbers[counter] = num;
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
        public static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }

            return num;
        }
    }
}
