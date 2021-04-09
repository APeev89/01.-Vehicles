using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : Healed
    {
        private const int CONST_POWER = 80;
        public Druid(string name) : base(name, CONST_POWER)
        {
        }
    }
}
