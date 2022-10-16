using System;

namespace T03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            double courses = (double)numberOfPeople / capacityOfElevator;

            Console.WriteLine(Math.Ceiling(courses));

        }
    }
}
