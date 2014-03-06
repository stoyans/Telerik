using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        private int healthEffect;
        private int powerEffect;
        private int agressionEffect;

        public Supplement(int powerEffect, int healthEffect, int agressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = agressionEffect;
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
            private set
            {
                this.powerEffect = value;
            }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            private set
            {
                this.healthEffect = value;
            }
        }

        public int AggressionEffect
        {
            get { return this.agressionEffect; }
            private set
            {
                this.agressionEffect = value;
            }
        }
    }
}
