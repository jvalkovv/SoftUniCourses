using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            string[] urls = Console.ReadLine().Split();

            foreach (string number in numbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        Smartphone smartphone = new Smartphone(number);
                        Console.WriteLine(smartphone.Call());
                    }
                    else if (number.Length == 7)
                    {
                        StationaryPhone stationaryPhone = new StationaryPhone(number);
                        Console.WriteLine(stationaryPhone.Call());
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string site in urls)
            {
                try
                {
                    Smartphone smartphone = new Smartphone(string.Empty, site);
                    Console.WriteLine(smartphone.Browse());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}
