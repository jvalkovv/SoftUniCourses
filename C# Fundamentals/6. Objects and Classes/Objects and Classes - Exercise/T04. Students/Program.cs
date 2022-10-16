using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Students
{
    class Student
    {
        public Student(string fistName, string lastname, double grade)
        {
            this.FirstName = fistName;
            this.LastName = lastname;
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfStudents; i++)
            {
                string[] studentSpecification = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currFirstName = studentSpecification[0];
                string currLastName = studentSpecification[1];
                double currGrade = double.Parse(studentSpecification[2]);

                Student currStudentObject = new Student(currFirstName, currLastName, currGrade);

                students.Add(currStudentObject);
            }

            students=students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            //List<Student> orderedStudent = students
            //    .OrderByDescending(s => s.Grade).ToList();

            //foreach (Student student in orderedStudent)
            //{
            //    Console.WriteLine(student);
            //}

        }
    }
}
