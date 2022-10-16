using System;

namespace T09._Padawan_Equipment
{
    internal class Program
    {


        static void Main(string[] args)
        {

            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfSingleLightsabers = double.Parse(Console.ReadLine());
            double priceOfSingleRobes = double.Parse(Console.ReadLine());
            double priceOfSingleBelts = double.Parse(Console.ReadLine());

            double priceOfAllBelts = 0;
            double priceOfAllRobes = 0;
            double priceOfAllleLightsabers = 0;
            double freeBelts = 0;
            if (countOfStudents >=6)
            {
                 freeBelts = countOfStudents / 6;
               
                
            }
            priceOfAllBelts = countOfStudents * priceOfSingleBelts - freeBelts*priceOfSingleBelts;

            double moreSabersForStudents = countOfStudents;
            double moreSabers =Math.Ceiling(moreSabersForStudents + moreSabersForStudents * 0.10);

            priceOfAllleLightsabers = moreSabers*priceOfSingleLightsabers;
            priceOfAllRobes = countOfStudents * priceOfSingleRobes;

            double neededMoney = priceOfAllBelts + priceOfAllleLightsabers + priceOfAllRobes;

            double finalPrice = Math.Abs(amountOfMoney - neededMoney);

            if (finalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else if (finalPrice > amountOfMoney)
            {
                Console.WriteLine($"John will need {finalPrice:f2}lv more.");
            }
        }
    }
}
