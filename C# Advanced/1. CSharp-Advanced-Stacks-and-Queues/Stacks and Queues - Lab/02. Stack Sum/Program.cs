using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackSum = new Stack<int>(numbers);
            string cmd;

            while ((cmd = Console.ReadLine().ToUpper()) != "END")
            {
                string[] array = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = array[0];
                if (action == "ADD")
                {
                    int first = int.Parse(array[1]);
                    int second = int.Parse(array[2]);

                    stackSum.Push(first);
                    stackSum.Push(second);
                }
                if (action == "REMOVE")
                {
                    int count = int.Parse(array[1]);

                    if (stackSum.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackSum.Pop();
                        }
                    }     
                }
            }
            Console.WriteLine($"Sum: {stackSum.Sum()}");
        }
    }
}
