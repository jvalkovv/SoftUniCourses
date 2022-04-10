using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Poisonous_Plants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPlants = int.Parse(Console.ReadLine());

            var plantsInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToList();

            Stack<int> indexOfDeadPlants = new Stack<int>();

            int dayCounter = 0;

            while (true)
            {
                dayCounter++;

                int dayOfDead = 0;

                for (int i = 0; i < countOfPlants-1; i++)
                {
                    if (plantsInfo[i + 1] > plantsInfo[i])
                    {
                        indexOfDeadPlants.Push(i + 1);
                        dayOfDead = 1;
                    }
                }

                int countOfDeadPlats = indexOfDeadPlants.Count();

                for (int i = 0; i < countOfDeadPlats; i++)
                {
                    plantsInfo.RemoveAt(indexOfDeadPlants.Pop());
                }
                countOfPlants = plantsInfo.Count();

                if (dayOfDead == 0)
                {
                    Console.WriteLine(dayCounter-1);
                    return;
                }
            }
        }
    }
}
