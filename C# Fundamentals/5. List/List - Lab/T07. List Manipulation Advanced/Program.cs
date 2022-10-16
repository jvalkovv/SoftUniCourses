using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            bool hasChanged = false;
            while (command != "end")
            {
                string[] array = command.Split(' ');
                string action = array[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(array[1]);
                    list.Add(numberToAdd);
                     hasChanged = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(array[1]);
                    list.Remove(numberToRemove);
                    hasChanged = true;
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(array[1]);
                    list.RemoveAt(indexToRemove);
                    hasChanged = true;
                }
                else if (action == "Insert")
                {
                    int elementToInsert = int.Parse(array[1]);
                    int indexToInsert = int.Parse(array[2]);
                    list.Insert(indexToInsert, elementToInsert);
                    hasChanged = true;
                }

                if (action == "Contains")
                {
                    int numbers = int.Parse(array[1]);

                    if (list.Contains(numbers))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = list.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = list.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                    
                }
                else if (action == "GetSum")
                {
                    int sum = list.Sum();
                    Console.WriteLine(sum);       
                }
                else if (action=="Filter")
                {
                    string condition = array[1];
                    int numberToCompare = int.Parse(array[2]);
                    List<int> result = GetFilteredNumber(list, condition, numberToCompare);
                    Console.WriteLine(string.Join(" ", result));                  
                }
                command = Console.ReadLine();
            }

            if (hasChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static List<int> GetFilteredNumber(List<int> allNumbers, string condition, int numberToCompare)
        {
            if (condition=="<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberToCompare);
                return result;
            }
            if (condition==">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToCompare);
                return result;
            }
            if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToCompare);
                return result;

            }
            if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }

        }
    }

}
