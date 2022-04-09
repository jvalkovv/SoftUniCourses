using System;
using System.Collections.Generic;

namespace _05._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] boy = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());
            Queue<string> result = new Queue<string>(boy);

            while (result.Count > 1)
            {
                for (int k = 1; k < n; k++)
                {
                    result.Enqueue(result.Dequeue());
                }

                Console.WriteLine($"Removed {result.Dequeue()}");
            }
            Console.WriteLine($"Last is {result.Dequeue()}");
        }
    }
}
