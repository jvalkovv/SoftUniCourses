using System;
using System.Linq;

namespace T01.Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberOfDays =
            {           
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int day = int.Parse(Console.ReadLine());

            if (day >=1 && day <= numberOfDays.Length)
            {
                Console.WriteLine(numberOfDays[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
