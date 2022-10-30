using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> raide = new List<BaseHero>();
            BaseHero hero;

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    if (type == "Druid")
                    {
                        hero = new Druid(name);
                    }
                    else if (type == "Paladin")
                    {
                        hero = new Paladin(name);
                    }
                    else if (type == "Rogue")
                    {
                        hero = new Rogue(name);

                    }
                    else if (type == "Warrior")
                    {
                        hero = new Warrior(name);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }

                    counter++;

                    raide.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            long bossPower = long.Parse(Console.ReadLine());

            long allPower = 0;

            foreach (var r in raide)
            {
                Console.WriteLine(r.CastAbility());
                allPower += r.Power;
            }


            if (allPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
