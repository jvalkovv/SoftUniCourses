using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IRobotOrCitizen> RobotsAndCitizens = new List<IRobotOrCitizen>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                if (tokens.Length == 3)
                {
                    RobotsAndCitizens.Add
                        (new Citizens(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else if (tokens.Length == 2)
                {
                    RobotsAndCitizens.Add(new Robots(tokens[0], tokens[1]));
                }
            }

            string lastDigits = Console.ReadLine();

            RobotsAndCitizens.Where(c => c.Id.EndsWith(lastDigits))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
