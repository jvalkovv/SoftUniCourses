using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizens : IRobotOrCitizen
    {
        private string name;
        private int age;
        public string Id { get; private set; }

        public Citizens(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
        }

    }
}
