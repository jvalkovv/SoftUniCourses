﻿using System;

namespace T02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            double dollars = pounds * 1.31;

            Console.WriteLine($"{(decimal)dollars:f3}");

        }
    }
}
