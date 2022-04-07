using System;
using System.Text;

namespace T07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeated = Console.ReadLine();
            int countOfRepeats = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(repeated,countOfRepeats));
        }
        static string RepeatString(string str, int count)
        {
            StringBuilder stringBuilder = new StringBuilder();  

            for (int i = 0; i < count; i++)
            {
               stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }
    }
}
