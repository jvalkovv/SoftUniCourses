using System;

namespace T01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int distaceOfMeters = int.Parse(Console.ReadLine());

            double distanceOfKilometers = distaceOfMeters / 1000.00;

            Console.WriteLine($"{(decimal)distanceOfKilometers:f2}");
        }
    }
}
