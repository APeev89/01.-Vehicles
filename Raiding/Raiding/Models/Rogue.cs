using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : Hitting
    {
        private const int CONST_POWER = 80;
        public Rogue(string name) : base(name, CONST_POWER)
        {
        }
    }
}
