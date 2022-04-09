using System;
using System.Collections.Generic;

namespace _06._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbOfCars = int.Parse(Console.ReadLine());
            int countOfCars = 0;

            string cmd;

            Queue<string> cars = new Queue<string>();

            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd == "green")
                {
                    for (int i = 0; i < numbOfCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                            countOfCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(cmd);
                }
            }
            Console.WriteLine($"{countOfCars} cars passed the crossroads.");
        }
    }
}
