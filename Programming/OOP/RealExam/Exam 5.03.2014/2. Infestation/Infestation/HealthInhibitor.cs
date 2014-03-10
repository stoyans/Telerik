using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HealthInhibitor : Inhibitor
    {
        public HealthInhibitor() :
            base(0, 3, 0)
        { 
        }
    }
}
