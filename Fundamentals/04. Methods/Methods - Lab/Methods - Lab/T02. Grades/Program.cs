using System;

namespace T02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);
        }
        static void Grades(double mark)
        {
            string grades = string.Empty;

            if (mark >= 2.00 && mark <= 2.99)
            {
                grades = "Fail";
            }
            else if (mark >= 3.00 && mark <= 3.49)
            {
                grades = "Poor";
            }
            else if (mark >= 3.50 && mark <= 4.49)
            {
                grades = "Good";
            }
            else if (mark >= 4.50 && mark <= 5.49)
            {
                grades = "Very good";
            }
            else if (mark >= 5.50 && mark <= 6.00)
            {
                grades = "Excellent";
            }
            Console.WriteLine(grades);
        }
    }
}
