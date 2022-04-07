using System;
using System.Linq;

namespace T03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] number = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();



            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 0)
                {
                    number[i] = 0;
                }
                double item = number[i];
               
                Console.WriteLine($"{number[i]} => {Math.Round(item, MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
