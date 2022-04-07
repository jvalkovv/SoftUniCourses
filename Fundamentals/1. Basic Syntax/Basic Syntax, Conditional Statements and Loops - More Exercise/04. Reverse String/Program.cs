using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] reversed = input.Reverse().ToArray();

            Console.WriteLine(reversed);
        }
    }
}
