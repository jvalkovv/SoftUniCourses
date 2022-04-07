using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());


            for (int i = numberTwo; i <= 10; i++)
            {
                
                Console.WriteLine($"{numberOne} X {i} = {numberOne * i}");
            }
            if (numberTwo > 10)
            {

                Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
            }
        }
    }
}
