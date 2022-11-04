using System;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int sum = 0;
            foreach (var item in input)
            {
                try
                {
                    int number = Int32.Parse(item);
                    sum += Int32.Parse(item);
                    Console.WriteLine
                        ($"Element '{item}' processed - current sum: {sum}");

                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
