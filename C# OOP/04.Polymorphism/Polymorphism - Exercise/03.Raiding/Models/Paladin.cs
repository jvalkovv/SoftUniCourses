using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int PaladinHealpower = 100;
        public Paladin(string name) : base(name) { }

        public override int Power => PaladinHealpower;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {PaladinHealpower}";
        }
    }

}
