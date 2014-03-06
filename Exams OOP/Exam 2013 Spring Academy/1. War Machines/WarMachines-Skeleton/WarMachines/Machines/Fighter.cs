using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Engine;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Fighter : Machine, IFighter
    {

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealth) :
            base(name, 200, attackPoints, defensePoints)
        {
            this.StealthMode = stealth;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.stealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " *Stealth: " + (this.StealthMode ? "ON" : "OFF");
        }

    }
}
