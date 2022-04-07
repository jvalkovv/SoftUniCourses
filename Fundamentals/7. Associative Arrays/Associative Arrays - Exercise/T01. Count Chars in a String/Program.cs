using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine(); 

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var ch in command)
            {
                if (!counts.ContainsKey(ch))
                {
                    counts.Add(ch, 1);
                }
                else
                {
                    counts[ch]++; 
                }
            }

            foreach (var ch in counts.Where(c=> c.Key !=' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }

        }
    }
}
