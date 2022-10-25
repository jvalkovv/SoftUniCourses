using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebration
{
    public class Pet : IBirthday
    {
        private string name;
        public Pet(string name, string birtdate)
        {
            this.name = name;
            this.birthdate = birtdate;
        }

        public string birthdate { get; private set; }
    }
}
