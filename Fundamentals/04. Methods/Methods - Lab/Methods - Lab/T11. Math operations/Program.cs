using System;

namespace T11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNumber,operation, secondNumber));
        }

        static double Calculate(int firsNumber, char operation, int seconNumber)
        {
            double result = 0;

            if (operation == '/')
            {
                result = firsNumber / seconNumber;
            }
            else if (operation == '*')
            {
                result = firsNumber * seconNumber;
            }
            else if (operation == '+')
            {
                result = firsNumber + seconNumber;
            }
            else if (operation == '-')
            {
                result = firsNumber - seconNumber;
            }
            return result;

        }
    }
}
