using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        const int weaponValue = 10;

        public Weapon(string name, Location location = null)
            :base(name, Weapon.weaponValue, ItemType.Weapon, location)
        {

        }
    }
}
