using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : Hitting
    {
        private const int CONST_POWER = 100;
        public Warrior(string name) : base(name, CONST_POWER)
        {
        }

    }
}
