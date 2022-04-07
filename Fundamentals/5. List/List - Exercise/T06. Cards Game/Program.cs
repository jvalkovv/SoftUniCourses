using System;
using System.Linq;
using System.Collections.Generic;

namespace T06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPLayer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstPlayer.Count > 0 && secondPLayer.Count > 0)
            {
                int handFromFirstPLayer = firstPlayer[0];
                int handFromSecondPLayer = secondPLayer[0];

                if (handFromFirstPLayer > handFromSecondPLayer)
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPLayer[0]);
                }
                else if (handFromSecondPLayer > handFromFirstPLayer)
                {
                    secondPLayer.Add(secondPLayer[0]);
                    secondPLayer.Add(firstPlayer[0]);
                }

                firstPlayer.RemoveAt(0);
                secondPLayer.RemoveAt(0);
            }

            string winner = string.Empty;
            List<int> winnerList = new List<int>();

            if (firstPlayer.Count > 0)
            {
                winnerList = firstPlayer.ToList();
                winner = "First";
            }
            else
            {
                winnerList = secondPLayer.ToList();
                winner = "Second";
            }
            Console.WriteLine($"{winner} player wins! Sum: {winnerList.Sum()}");
        }
    }
}
