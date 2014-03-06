﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {

        private int attackPoints = 0;

        public Ninja(string name, Point position, int owner) :
            base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var targetHighestHitPoints = availableTargets.Max(target => target.HitPoints);

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[0].Owner != 0 && availableTargets[0].Owner != this.Owner
                    && availableTargets[0].HitPoints == targetHighestHitPoints)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += resource.Quantity * 2;
                return true;
            }
            else if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }

            return false;
        }
        
    }
}
