using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebration
{
    public class Citizen : IIdentifiable, IBirthday
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.birthdate = birthdate;
        }

        public string Id { get; private set; }
        public string birthdate { get; private set; }
    }
}