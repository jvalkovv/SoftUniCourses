using System;

namespace T5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string products = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            if (products == "coffee")
            {
                price = 1.50;
                coffee(price, count);
            }
            else if (products == "water")
            {
                price = 1.00;
                water(price, count);
            }
            else if (products == "coke")
            {
                price = 1.40;
                coke(price, count);
            }
            else if (products == "snacks")
            {
                price = 2.00;
                snacks(price, count);
            }
        }

        static void snacks(double price, int count)
        {
            Console.WriteLine($"{price * count:f2}");
        }

        static void coke(double price, int count)
        {
            Console.WriteLine($"{price * count:f2}");
        }

        static void water(double price, int count)
        {
            Console.WriteLine($"{price * count:f2}");
        }

        static void coffee(double price, int count)
        {
            Console.WriteLine($"{price * count:f2}");
        }
    }
}
