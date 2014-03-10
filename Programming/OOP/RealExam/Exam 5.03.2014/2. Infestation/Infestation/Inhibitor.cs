using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Inhibitor : Supplement
    {
        public Inhibitor(int powerEffect, int healthEffect, int agressionEffect) :
            base(powerEffect, healthEffect, agressionEffect)
        { 
        }
    }
}
