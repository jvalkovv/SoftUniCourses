using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine().ToLower();

            var age = int.Parse(Console.ReadLine());
            var priceOfticket = 0;

            if (age >= 0 && age <= 122)
            {


                if (typeOfDay == "weekday")
                {
                    if (age >= 0 && age <= 18)
                    {
                        priceOfticket = 12;
                    }
                    if (age > 18 && age <= 64)
                    {
                        priceOfticket = 18;
                    }
                    if (age > 64 && age <= 122)
                    {
                        priceOfticket = 12;
                    }
                 

                }
                else if (typeOfDay == "weekend")
                {
                    if (age >= 0 && age <= 18)
                    {
                        priceOfticket = 15;
                    }
                    if (age > 18 && age <= 64)
                    {
                        priceOfticket = 20;
                    }
                    if (age > 64 && age <= 122)
                    {
                        priceOfticket = 15;
                    }
                }
                else if (typeOfDay == "holiday")
                {
                    if (age >= 0 && age <= 18)
                    {
                        priceOfticket = 5;
                    }
                    if (age > 18 && age <= 64)
                    {
                        priceOfticket = 12;
                    }
                    if (age > 64 && age <= 122)
                    {
                        priceOfticket = 10;
                    }

                }
                Console.WriteLine($"{priceOfticket}$");
                
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }



        }
    }
}
