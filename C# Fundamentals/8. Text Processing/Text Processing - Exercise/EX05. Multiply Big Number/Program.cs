using System;
using System.Collections.Generic;

namespace EX05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string bigNumber = Console.ReadLine();

            bigNumber = bigNumber.TrimStart(new char[] { '0' });

            char [] bigNum = bigNumber.ToCharArray();
            
            int number = int.Parse(Console.ReadLine());

            if (number==0)
            {
                Console.WriteLine("0");
                return;
            }

            List<string> result = new List<string>();

            int sum = 0;

            for (int i = bigNum.Length-1; i >= 0; i--)
            {
                sum = (int.Parse(Convert.ToString(bigNum[i]))*number)+sum;
                result.Insert(0, (sum % 10).ToString());
                sum /= 10;
            }
            if (sum>0)
            {
                Console.WriteLine($"{sum}{string.Join("",result)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("",result)}");
            }
        }
    }
}
