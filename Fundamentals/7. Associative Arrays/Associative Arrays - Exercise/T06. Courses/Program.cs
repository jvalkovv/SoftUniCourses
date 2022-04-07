using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string lineCmd;

            while ((lineCmd = Console.ReadLine()) != "end")
            {
                string[] course = lineCmd
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string nameOfCourse = course[0];
                string nameOfStudent = course[1];

                if (!courses.ContainsKey(nameOfCourse))
                {
                    courses.Add(nameOfCourse, new List<string>() { nameOfStudent });

                }
                else
                {
                    courses[nameOfCourse].Add(nameOfStudent);
                }

            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");

                foreach (var name in course.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }

        }
    }
}
