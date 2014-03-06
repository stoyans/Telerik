using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : Unit
    {

        public Parasite(string id) :
            base(id, UnitClassification.Biological, 1, 1, 1)
        { }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Id != this.Id)
            {
                return true;
            }
            return false;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            var leastHealth = attackableUnits.OrderBy(unit => unit.Health).First();
            optimalAttackableUnit = leastHealth;

            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
