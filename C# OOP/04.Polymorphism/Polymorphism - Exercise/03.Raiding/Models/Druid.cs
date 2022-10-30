using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int DruidHealpower = 80;
        public Druid(string name) : base(name) { }

        public override int Power => DruidHealpower;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {DruidHealpower}";
        }
    }
}
