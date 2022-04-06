using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string a = "";

            
                
            if (age >= 0 && age <= 2)
                    a = "baby";
            
            else if (age >= 3 && age <= 13)
            {
                a = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                a = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                a = "adult";
            }
            else if (age >= 66)
            {
                a = "elder";
            }

            Console.WriteLine(a);
        }
    }
}
