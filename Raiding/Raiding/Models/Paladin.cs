using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : Healed
    {
        private const int CONST_POWER = 100;
        public Paladin(string name) : base(name, CONST_POWER)
        {
        }
    }
}
