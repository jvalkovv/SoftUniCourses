using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace E02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> topRaces = new Dictionary<string, int>();
            List<string> inputRacers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string cmd = Console.ReadLine();

            while (cmd != "end of race")
            {
                string currName = string.Empty;
                int currPoints = 0;

                for (int i = 0; i < cmd.Length; i++)
                {
                    char currChar = cmd[i];

                    if (char.IsLetter(currChar))
                    {
                        currName += currChar;
                    }
                    if (char.IsDigit(currChar))
                    {
                        currPoints += (int)currChar;
                        currPoints -= 48;
                    }
                }
                if (inputRacers.Contains(currName))
                {
                    if (topRaces.ContainsKey(currName))
                    {
                        topRaces[currName] += currPoints;
                    }
                    else if (!topRaces.ContainsKey(currName))
                    {
                        topRaces.Add(currName, currPoints);
                    }
                }
                cmd = Console.ReadLine();
            }

            int counter = 1;
            topRaces = topRaces.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in topRaces)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
