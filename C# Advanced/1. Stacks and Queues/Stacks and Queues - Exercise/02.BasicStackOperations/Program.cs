using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elToPush = firstLine[0];
            int elToPop = firstLine[1];
            int elIsExist = firstLine[2];

            int[] secondLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> result = new Stack<int>();

            int minNumber = 0;
            bool exist = false;

            for (int i = 0; i < secondLine.Length; i++)
            {
                if (result.Count < elToPush)
                {
                    result.Push(secondLine[i]);
                }
                else
                {
                    break;
                }
            }
            if (result.Count >= elToPop)
            {
                for (int k = 0; k < elToPop; k++)
                {
                    result.Pop();
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result.Contains(elIsExist))
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }
                minNumber = result.Min();
            }
            if (exist == false)
            {
                Console.WriteLine(minNumber);
            }
            if (exist == true)
            {
                Console.WriteLine("true");
            }
        }
    }
}