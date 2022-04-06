using System;

namespace T07._Water_Overflow
{
    internal class Program
    {


        static void Main(string[] args)
        {
            const int TANK = 255;

            int numberOflines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberOflines; i++)
            {
                int currCapacity = int.Parse(Console.ReadLine());
                int allSum = sum + currCapacity;

                if (allSum > TANK)
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                else 
                {
                    sum += currCapacity;
                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}
