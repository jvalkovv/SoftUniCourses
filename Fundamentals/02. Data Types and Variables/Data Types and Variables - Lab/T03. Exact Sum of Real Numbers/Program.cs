using System;

namespace T03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal finalSum = 0;

            for (int i = 1; i <= number; i++)
            {
                decimal currNum=decimal.Parse(Console.ReadLine());
                finalSum += currNum;

            }

            Console.WriteLine($"{(decimal)finalSum}");

        }
    }
}
