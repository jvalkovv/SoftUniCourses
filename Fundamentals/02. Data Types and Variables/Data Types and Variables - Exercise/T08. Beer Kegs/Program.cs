using System;

namespace T08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string model = string.Empty;
            string biggestBeer = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestBeer = model;
                }
            }
            Console.WriteLine(biggestBeer);
        }
    }
}
