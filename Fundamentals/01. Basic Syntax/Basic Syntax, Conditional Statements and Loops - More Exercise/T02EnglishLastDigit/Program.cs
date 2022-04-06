using System;

namespace T02EnglishLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digigs = Console.ReadLine();
            int lastDigits = 0;
            for (int i = 0; i <= digigs.Length; i++)
            {

                int digit = int.Parse(digigs);
                lastDigits = digit % 10;
            }

            if (lastDigits == 1)
            {
                Console.WriteLine("one");
            }
            if (lastDigits == 2)
            {
                Console.WriteLine("two");
            }
            if (lastDigits == 3)
            {
                Console.WriteLine("three");
            }
            if (lastDigits == 4)
            {
                Console.WriteLine("four");
            }
            if (lastDigits == 5)
            {
                Console.WriteLine("five");
            }
            if (lastDigits == 6)
            {
                Console.WriteLine("six");
            }
            if (lastDigits == 7)
            {
                Console.WriteLine("seven");
            }
            if (lastDigits == 8)
            {
                Console.WriteLine("eight");
            }
            if (lastDigits == 9)
            {
                Console.WriteLine("nine");
            }
            if (lastDigits == 0)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
