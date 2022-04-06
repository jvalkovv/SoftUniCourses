using System;
using System.Linq;
namespace T07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            

            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += firstArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }             
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
