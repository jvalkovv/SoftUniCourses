using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] currLine = command.Split(" -> ").ToArray();

                string currCompany = currLine[0];
                string employeesID = currLine[1];

                if (!companyUsers.ContainsKey(currCompany))
                {
                    companyUsers.Add(currCompany, new List<string>());
                }

                if (!companyUsers[currCompany].Contains(employeesID))
                {
                    companyUsers[currCompany].Add(employeesID);
                }

            }
            foreach (var course in companyUsers)
            {
                Console.WriteLine($"{course.Key}");

                foreach (var name in course.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
