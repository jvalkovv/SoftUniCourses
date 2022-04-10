using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthes = new Stack<char>();

            foreach (var symbol in input)
            {
                if (parenthes.Count > 0)
                {
                    char check = parenthes.Peek();

                    if (check == '{' && symbol == '}')
                    {
                        parenthes.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        parenthes.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        parenthes.Pop();
                        continue;
                    }
                }
                parenthes.Push(symbol);
            }
            if (parenthes.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}