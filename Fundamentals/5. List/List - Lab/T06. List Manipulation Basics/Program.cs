using System;
using System.Linq;
using System.Collections.Generic;

namespace T06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command. Split(' ');

                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    list.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    list.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    list.RemoveAt(indexToRemove);
                }
                else if (action == "Insert")
                {
                    int elementToInsert = int.Parse(token[1]);
                    int indexToInsert = int.Parse(token[2]);
                    list.Insert(indexToInsert, elementToInsert);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
