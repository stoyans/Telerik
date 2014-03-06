using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Forest : GatheringLocation
    {

        //const string forestName = "Cherokee";

        public Forest(string name):
            base(name, LocationType.Forest, ItemType.Wood, ItemType.Wood)
        {

        }

        public override Item ProduceItem(string itemName)
        {
            return new Wood(itemName, null);
        }
    }
}
