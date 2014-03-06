using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace WarMachines
{
    public class Pilot : IPilot
    {
        private IList<IMachine> engagedMachines;
        private string name;


        public Pilot(string name)
        {
            this.Name = name;
            this.engagedMachines = new List<IMachine>();
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

        public void AddMachine(IMachine machine)
        {
            engagedMachines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.Append(this.Name.ToString() + " - ");
            if (engagedMachines.Count > 1)
            {
                report.Append(engagedMachines.Count + " ");
                report.Append("machines");
                //report.Append(Environment.NewLine);
            }
            else if (engagedMachines.Count == 1)
            {
                report.Append(engagedMachines.Count + " ");
                report.Append("machine");
                report.Append(Environment.NewLine);
            }
            else 
            {
                report.Append("no ");
                report.Append("machines");
            }

            var orderedMachines = engagedMachines.OrderBy(machine => machine.HealthPoints).
                ThenBy(machine => machine.Name);

            foreach (var machine in orderedMachines)
            {
                report.Append("- " + machine.Name);
                report.Append(Environment.NewLine);
                report.Append(machine.ToString());
            }

            return report.ToString();
        }
    }
}
