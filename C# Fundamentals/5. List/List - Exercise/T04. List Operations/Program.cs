using System;
using System.Linq;
using System.Collections.Generic;

namespace T04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] array = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = array[0];

                if (action == "Add")
                {
                    int numb = int.Parse(array[1]);

                    number.Add(numb);

                }
                else if (action == "Insert")
                {
                    int insertNumber = int.Parse(array[1]);
                    int indexOfNumber = int.Parse(array[2]);

                    if (!IsIndexValid(number, indexOfNumber))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    number.Insert(indexOfNumber, insertNumber);
                }
                else if (action == "Remove")
                {
                    int removeIndex = int.Parse(array[1]);

                    if (!IsIndexValid(number, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    number.RemoveAt(removeIndex);
                }
                else if (action == "Shift")
                {
                    string direction = array[1];

                    int count = int.Parse(array[2]);

                    if (direction == "left")
                    {
                        ShiftLeft(number, count);
                    }
                    else if (direction == "right")
                    {
                        ShiftRight(number, count);
                    }
                }

            }

            Console.WriteLine(string.Join(" ", number));
        }

        static bool IsIndexValid(List<int> number, int index)
        {
            return index >= 0 && index < number.Count;
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int cnt = 0; cnt < realPerformedCount; cnt++)
            {
                int firstElement = numbers.First();

                numbers.Remove(firstElement);

                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int cnt = 0; cnt < realPerformedCount; cnt++)
            {
                int lastElement = numbers.Last();

                numbers.RemoveAt(numbers.Count - 1);

                numbers.Insert(0, lastElement);
            }
        }
    }
}
