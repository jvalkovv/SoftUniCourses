using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.Salary = salary;
        }
        public string FirstName { get; private set; }  
        public string LastName { get; private set; }
        public int Age { get; set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
               this.Salary = this.Salary * (percentage/2)/100 + this.Salary;
            }
            else
            {
                this.Salary = this.Salary * percentage/100 + this.Salary;
            }

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.");
            return sb.ToString().TrimEnd();
        }
    }
}
