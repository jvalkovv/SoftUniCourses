using System;
using System.Collections.Generic;

namespace _03.HeroRecruitment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> heroAndSpells = new Dictionary<string, List<string>>();

                      
            string cmd;

            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] array = cmd.Split(' ');

                string action = array[0];

                if (action == "Enroll")
                {
                    string heroName = array[1];

                    if (!heroAndSpells.ContainsKey(heroName))
                    {
                        heroAndSpells.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                if (action == "Learn")
                {
                    string heroName = array[1];
                    string spellName = array[2];

                    if (!heroAndSpells.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (heroAndSpells.ContainsKey(heroName))
                    {
                        if (!(heroAndSpells[heroName].Contains(spellName)))
                        {
                            heroAndSpells[heroName].Add(spellName);
                        }
                        else if (heroAndSpells[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }

                }
                if (action == "Unlearn")
                {
                    string heroName = array[1];
                    string spellName = array[2];

                    if (heroAndSpells.ContainsKey(heroName))
                    {
                        if (heroAndSpells[heroName].Contains(spellName))
                        {
                            heroAndSpells[heroName].Remove(spellName);
                        }

                    }
                    else if (!heroAndSpells.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else if (!heroAndSpells[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} doesn't know {spellName}");
                    }
                }
            }
            Console.WriteLine("Heroes:");
            foreach (var item in heroAndSpells)
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
