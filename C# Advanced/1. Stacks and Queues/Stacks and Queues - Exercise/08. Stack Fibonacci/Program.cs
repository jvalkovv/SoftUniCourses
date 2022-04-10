using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Stack_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Stack<long> fibonacci = new Stack<long>();
            fibonacci.Push(1);
            fibonacci.Push(1);

            for (int i = 0; i < count - 1; i++)
            {
                if (fibonacci.Count == count)
                {
                    break;
                }
                long first = fibonacci.Pop();
                long second = fibonacci.Peek();
                fibonacci.Push(first);
                fibonacci.Push(first + second);
            }
            var result = fibonacci.Pop();
            Console.WriteLine(result);
        }
    }
}
