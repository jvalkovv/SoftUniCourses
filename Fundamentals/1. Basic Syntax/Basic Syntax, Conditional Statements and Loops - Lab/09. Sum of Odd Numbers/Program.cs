using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;
            bool hasEnoughNumber = false;
            int counter = 1;
            int i = 0;

            while (!hasEnoughNumber)
            {
                if (counter==number)
                {
                    hasEnoughNumber = true;
                }
                int currenOdNumber = 1 + (i * 2);
                sum += currenOdNumber;
                Console.WriteLine($"{currenOdNumber}");
                i++;
                counter++;
                    
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
