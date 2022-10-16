using System;

namespace T04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfChar = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numberOfChar; i++)

            {
                char currCh = char.Parse(Console.ReadLine());
                int currChCode = (int)currCh;
                totalSum += currChCode;

            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
