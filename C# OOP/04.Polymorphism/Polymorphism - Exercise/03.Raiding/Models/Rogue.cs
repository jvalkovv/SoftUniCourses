using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int RogueHitPower = 80;
        public Rogue(string name) : base(name) { }
        public override int Power => RogueHitPower;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {RogueHitPower} damage";
        }

    }
}
