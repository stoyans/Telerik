namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    using System;

    public class MachineFactory : IMachineFactory
    {
        private List<string> usedNames = new List<string>();

        public IPilot HirePilot(string name)
        {
            return new Pilot(name);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            return new Tank(name, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            return new Fighter(name, attackPoints, defensePoints, stealthMode);
        }
    }
}
