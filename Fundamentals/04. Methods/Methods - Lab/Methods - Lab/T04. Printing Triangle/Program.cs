using System;

namespace T04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintLines(number);

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void PrintLines(int number)
        {
            for (int i = 1; i < number; i++)
            {
               PrintLine(1, i);
            }

            for (int i = number; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
