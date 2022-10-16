using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>();

            string commad = Console.ReadLine();
            
            while (commad != "stop")
            {
                int qunatity = int.Parse(Console.ReadLine());
               
                if (!dic.ContainsKey(commad))
                {
                    dic.Add(commad, 0);
                }

                dic[commad] += qunatity;

                commad = Console.ReadLine();
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            
        }
    }
}

