using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForSinglePerson = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    priceForSinglePerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    priceForSinglePerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    priceForSinglePerson = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    priceForSinglePerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    priceForSinglePerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    priceForSinglePerson = 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    priceForSinglePerson = 15;
                }
                else if (day == "Saturday")
                {
                    priceForSinglePerson = 20;
                }
                else if (day == "Sunday")
                {
                    priceForSinglePerson = 22.50;
                }
            }
            double price = countOfPeople * priceForSinglePerson;
            if (countOfPeople >= 30 && type == "Students")
            {
                price *= 0.85;
            }
            else if (countOfPeople >= 100 && type == "Business")
            {
                countOfPeople -= 10;
                price = countOfPeople * priceForSinglePerson;
            }
            else if (countOfPeople >= 10 && countOfPeople <= 20 && type == "Regular")
            {
                price *= 0.95;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}