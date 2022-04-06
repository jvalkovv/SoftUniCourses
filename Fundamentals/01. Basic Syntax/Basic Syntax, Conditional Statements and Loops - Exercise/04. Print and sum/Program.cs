using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int num = int.Parse(Console.ReadLine());
            int currenNumber = 0;
            for (int i = number; i <= num; i++)
            {
                currenNumber += i;
                
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {currenNumber}");
        }
    }
}
