﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {

        private int attackPoints = 150;
        private int defensePoints = 80;
        private bool isIncreased = false;

        public Giant(string name, Point position) :
            base(name, position, 0)
        {
            this.HitPoints = 200;
        }
        public int AttackPoints
        {
            get { return attackPoints; }
        }

        public int DefensePoints
        {
            get { return defensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
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
                if (isIncreased == false)
                {
                    isIncreased = true;
                    this.attackPoints += 100;    
                }
                
                return true;
            }

            return false;
        }
    }
}
