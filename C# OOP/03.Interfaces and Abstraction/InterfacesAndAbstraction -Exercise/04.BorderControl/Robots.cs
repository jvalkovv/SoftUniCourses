using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robots : IRobotOrCitizen
    {
        private string model;
        public string Id { get; private set; }

        public Robots(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

    }
}
