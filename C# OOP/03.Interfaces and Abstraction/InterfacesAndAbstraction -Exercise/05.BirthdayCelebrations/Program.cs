using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthday> haveABirthday = new List<IBirthday>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var tokens = command.Split();

                if (tokens[0] == "Citizen")
                {
                    haveABirthday.Add
                        (new Citizen(tokens[1], int.Parse(tokens[2]),
                        tokens[3],tokens[4]));
                }
                else if (tokens[0] == "Pet")
                {
                    haveABirthday.Add
                        (new Pet(tokens[1],tokens[2]));
                }
            }

            var specificYear = Console.ReadLine();


            haveABirthday.Where(c => c.birthdate.EndsWith(specificYear))
                .Select(c => c.birthdate)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
