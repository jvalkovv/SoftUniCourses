using System;

namespace T06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = (char)(n + 97);

            for (char i = 'a'; i < ch; i++)
            {
                for (char j = 'a'; j < ch; j++)
                {  
                    for (char k = 'a'; k < ch; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
                
            }
            
        }
    }
}
