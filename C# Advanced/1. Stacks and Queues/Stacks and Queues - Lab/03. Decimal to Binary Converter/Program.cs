using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Decimal_to_Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            if (number == 0)
            {
                Console.WriteLine("0");
            }

            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    int remainder = number % 2;
                    number /= 2;
                    list.Add(remainder);
                }
                else if (number % 2 == 0)
                {
                    int remainder = number % 2;
                    number /= 2;
                    list.Add(remainder);
                }
            }
          
            Stack<int> results = new Stack<int>(list);

            while (results.Count > 0)
            {
                Console.Write(results.Pop());
            }
        }
    }
}
