using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines.Engine
{
    public abstract class Machine : IMachine
    {
        private string name;
        private double healthPoints;
        private IList<string> targets;
        private double attackPoints;
        private double defensePoints;
        private IPilot pilot;

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
            private set { this.targets = value; }
        }

        public void Attack(string target)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder machineString = new StringBuilder();

            string targets = null;
            if (this.targets.Count != 0)
            {
                targets = string.Join(", ", this.targets);
            }

            machineString.Append(" *Type: " + GetType().Name);
            machineString.Append(System.Environment.NewLine);
            machineString.Append(" *Health: " + this.healthPoints);
            machineString.Append(System.Environment.NewLine);
            machineString.Append(" *Attack: " + this.attackPoints);
            machineString.Append(System.Environment.NewLine);
            machineString.Append(" *Defense: " + this.defensePoints);
            machineString.Append(System.Environment.NewLine);
            machineString.Append(" *Targets: " + (targets ?? "None"));
            machineString.Append(System.Environment.NewLine);
            return machineString.ToString();
        }
    }
}
