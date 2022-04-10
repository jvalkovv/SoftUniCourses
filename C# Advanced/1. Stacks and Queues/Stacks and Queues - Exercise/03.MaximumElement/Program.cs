using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string action = tokens[0];

                if (action == "1")
                {
                    int currNumber = int.Parse(tokens[1]);
                    numbers.Push(currNumber);
                }
                else if (action == "2")
                {
                    numbers.Pop();
                }
                else if (action=="3")
                {
                    Console.WriteLine($"{numbers.Max()}");
                }
            }

        }
    }
}