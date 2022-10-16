using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> validCars = new Dictionary<string, string>();

            

            int numberOfLine = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLine; i++)
            {
                string[] currPersonCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currStatus = currPersonCar[0];
                string currPersonName = currPersonCar[1];

                if (currStatus == "register")
                {
                string licensePlateNumber = currPersonCar[2];

                    if (!validCars.ContainsKey(currPersonName))
                    {
                        validCars.Add(currPersonName, licensePlateNumber);
                        Console.WriteLine($"{currPersonName} registered {licensePlateNumber} successfully");

                    }
                    else if (validCars.ContainsKey(currPersonName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                if (currStatus == "unregister")
                {
                    if (validCars.ContainsKey(currPersonName))
                    {
                        validCars.Remove(currPersonName);
                        Console.WriteLine($"{currPersonName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {currPersonName} not found");
                    }
                }
            }

            foreach (var kvp in validCars)
            {

                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }


        }
    }
}
