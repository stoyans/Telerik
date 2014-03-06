using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Engine;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Tank : Machine, ITank
    {

        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints) :
            base(name, 100, attackPoints, defensePoints)
        {
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (!this.defenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} *Defense: {1}", base.ToString() + Environment.NewLine, this.DefenseMode ? "ON" : "OFF");
        }
    }
}
