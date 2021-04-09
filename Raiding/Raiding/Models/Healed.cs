using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class Healed : BaseHero
    {
        public Healed(string name, int power) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
