using System;
using System.Linq;
using System.Collections.Generic;

namespace T05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (true)
            {
                
                int indexOfBomb = list.IndexOf(bombNumber);

                if (indexOfBomb==-1)
                {
                    break;
                }
                DetonateBomb(list, indexOfBomb, bombPower);
            }
            Console.WriteLine(list.Sum());
        }
        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {
            int rightCount = indexOfBomb + bombPower;

            for (int cnt = indexOfBomb; cnt <= rightCount; cnt++)
            {
                if (indexOfBomb>=numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - bombPower;

            if (leftCount<0)
            {
                leftCount = 0;
            }
            for (int cnt = leftCount; cnt < indexOfBomb; cnt++)
            {
                numbers.RemoveAt(leftCount);
            }
        }
    }
}
