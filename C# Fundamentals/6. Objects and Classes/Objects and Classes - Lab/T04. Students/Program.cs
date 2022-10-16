using System;
using System.Collections.Generic;

namespace T04._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command;

            while ((command = Console.ReadLine())
                != "end")
            {
                string[] token = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string hometown = token[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                };

                students.Add(newStudent);
            }

            string filteredCity = Console.ReadLine();

            List<Student> filteredStudent = students.FindAll(s => s.Hometown == filteredCity);
            foreach (Student newStudent in filteredStudent)
            {
                Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName} is {newStudent.Age} years old.");
            }
        }
    }
}
