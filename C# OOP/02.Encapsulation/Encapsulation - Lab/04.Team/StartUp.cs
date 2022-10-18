using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();
                    var person = new Person(
                        input[0],
                        input[1],
                        int.Parse(input[2]),
                        decimal.Parse(input[3]));
                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine($"First team has {team.FirstTeam.Count()} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count()} players.");
        }
    }
}
