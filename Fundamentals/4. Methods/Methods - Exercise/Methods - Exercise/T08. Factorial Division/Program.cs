using System;

namespace T08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double firstNum = double.Parse(Console.ReadLine());
            double seconNum = double.Parse(Console.ReadLine());
            double result = PrintResult(firstNum, seconNum);
            Console.WriteLine($"{result:f2}");
        }

        static double PrintResult(double firstNum, double seconNum)
        {
            double firstFactorial = firstNum;
            double secondFactorial = seconNum;

            for (int first = 1; first < firstNum; first++)
            {
                firstFactorial *= first;
            }

            for (int second = 1; second < seconNum; second++)
            {
                secondFactorial *= second;
            }

            double result = firstFactorial/secondFactorial;

            return result;
        }
    }
}
