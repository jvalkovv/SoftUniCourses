using System;
using System.Collections.Generic;
using System.Linq;

namespace E02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> travelToTitam = Console.ReadLine()
                .Split("||")
                .ToList();

            int startingFuel = int.Parse(Console.ReadLine());

            int startingAmmu = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < travelToTitam.Count; cnt++)
            {
                List<string> command = travelToTitam[cnt].Split(" ").ToList();

                if (command[0] == "Enemy")
                {
                    int neededAmmun = int.Parse(command[1]);

                    if (startingAmmu >= neededAmmun)
                    {
                        startingAmmu -= neededAmmun;
                        Console.WriteLine($"An enemy with {neededAmmun} armour is defeated.");
                    }
                    else
                    {
                        if (neededAmmun * 2 <= startingFuel)
                        {
                            startingFuel -= neededAmmun * 2;
                            Console.WriteLine($"An enemy with {neededAmmun} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Repair")
                {
                    int number = int.Parse(command[1]);
                    startingAmmu += number * 2;
                    startingFuel += number;
                    Console.WriteLine($"Ammunitions added: {number*2}.");
                    Console.WriteLine($"Fuel added: {number}.");
                }

                else if (command[0] == "Travel")
                {
                    int distanceLight = int.Parse(command[1]);

                    if (startingFuel >= distanceLight)
                    {
                        startingFuel -= distanceLight;
                        Console.WriteLine($"The spaceship travelled {distanceLight} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }

            }

        }
    }
}

