using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            int numOfRow = int.Parse(Console.ReadLine());

          

            for (int i = 0; i < numOfRow; i ++)
            {
                string currName = Console.ReadLine();
                double currGrade = double.Parse(Console.ReadLine());

                if (!student.ContainsKey(currName))
                {
                    student.Add(currName, new List<double>() );
                }
                
                    student[currName].Add(currGrade);
                

            }
            foreach (var item in student)
            {
                if (item.Value.Average() >= 4.5)
                {
                   double averageGrade = item.Value.Average();
                Console.WriteLine($"{item.Key} -> {averageGrade:f2}");

                }
            }
        }
    }
}
