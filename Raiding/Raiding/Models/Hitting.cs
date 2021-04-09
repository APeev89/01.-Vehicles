using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class Hitting : BaseHero
    {
        public Hitting(string name, int power) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
