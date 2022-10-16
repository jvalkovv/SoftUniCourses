using System;
using System.Collections.Generic;
using System.Linq;


namespace T02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] array = command.Split(' ');
                
                string action = array[0];

                if (action=="Delete")
                {
                    int element = int.Parse(array[1]);

                    numbers.RemoveAll(x => x == element);
                }
                else if (action== "Insert")
                {
                    int element = int.Parse(array[1]);
                    int position = int.Parse(array[2]);

                    numbers.Insert(position, element);
                }


                command=Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
