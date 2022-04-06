using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string nation = Console.ReadLine();

            if (nation=="England" || nation=="USA")
            {
                Console.WriteLine("English");
            }
            else if (nation =="Spain" || nation=="Argentina" || nation=="Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
