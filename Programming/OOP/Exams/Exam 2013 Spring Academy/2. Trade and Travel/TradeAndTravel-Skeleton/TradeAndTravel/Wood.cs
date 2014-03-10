using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int woodValue = 2;

        public Wood(string name, Location location = null)
            :base(name, Wood.woodValue, ItemType.Wood, location)
        {

        }
    }
}
