using System;

namespace T03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            

            if (command == "add")
            {
                add(firstNumber, secondNumber);
            }
            else if (command == "multiply")
            {
                multiply(firstNumber, secondNumber);
            }
            else if (command == "subtract")
            {
                subtract(firstNumber, secondNumber);
            }
            else if (command == "divide")
            {
                divide(firstNumber, secondNumber);
            }
        }
        static void add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber+secondNumber);
        }
        static void multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }
        static void subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }
        static void divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
       
    }
}
