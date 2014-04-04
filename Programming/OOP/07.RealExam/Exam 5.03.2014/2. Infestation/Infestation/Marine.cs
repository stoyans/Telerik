using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Marine : Human
    {

        public Marine(string id)
            : base(id)
        {
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Power <= this.Aggression)
            {
                return true;
            }
            return false;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            var highestHealth = attackableUnits.OrderByDescending(unit => unit.Health).First();
            optimalAttackableUnit = highestHealth;

            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Attack);
            }

            return Interaction.PassiveInteraction;
        }

        public override void AddSupplement(ISupplement newSupplement)
        {
            base.AddSupplement(newSupplement);
        }

    }
}
