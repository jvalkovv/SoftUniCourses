using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> breckets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar == '(')
                {
                    breckets.Push(i);
                }
                else if (currChar == ')')
                {
                    int startIndex = breckets.Pop();
                    string newString = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(newString);
                }
            }


        }
    }
}
