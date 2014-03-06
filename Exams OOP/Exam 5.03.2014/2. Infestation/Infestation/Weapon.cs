using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : Supplement
    {
        public const int powerEffect = 10;
        public const int agressionEffect = 3;
        public const int healthEffect = 0;

        public Weapon() :
            base(powerEffect, healthEffect, agressionEffect)
        { }
    }
}
