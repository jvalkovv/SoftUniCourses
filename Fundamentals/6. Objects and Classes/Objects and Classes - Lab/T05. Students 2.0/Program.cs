using System;
using System.Collections.Generic;

namespace T04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }
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

                bool doesStudentExist = DoesStudentExsist(students, firstName, lastName);

                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.Hometown = hometown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, hometown);

                    students.Add(newStudent);
                }
            }

            string filteredCity = Console.ReadLine();

            List<Student> filteredStudent = students.FindAll(s => s.Hometown == filteredCity);
            foreach (Student newStudent in filteredStudent)
            {
                Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName} is {newStudent.Age} years old.");
            }
        }

        static Student GetExistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach (Student newStuden in students)
            {
                if (newStuden.FirstName == firstName && newStuden.LastName == lastName)
                {
                    return newStuden;
                }
            }
            return null;
        }

        static bool DoesStudentExsist(List<Student> newStudent, string firstName, string LaslastName)
        {
            foreach (Student students in newStudent)
            {
                if (students.FirstName == firstName && students.LastName == LaslastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
