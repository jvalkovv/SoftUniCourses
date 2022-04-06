using System;

namespace T01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            intChecker(numbers);
        }

        static void intChecker(int number)
        {
            if (number>0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number <0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number==0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
