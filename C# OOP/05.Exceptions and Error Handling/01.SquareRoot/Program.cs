using System;

namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            try
            {
                ValidSqr(number);
                Console.WriteLine(ValidSqr(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }


        }

        public static double ValidSqr(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            return Math.Sqrt(num);
        }
    }
}
