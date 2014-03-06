using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class AdvancedInteractionManager : InteractionManager
    {

        public AdvancedInteractionManager() :
            base()
        { 
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {

            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default: 
                    return base.CreateLocation(locationTypeString, locationName);
            }            
            
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "wood":
                    item = new Armor(itemNameString, itemLocation);
                    break;
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default: return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
            return item;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {

            switch (commandWords[0])
            {
                case "gather": this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft": this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default: base.HandlePersonCommand(commandWords, actor);
                    break;
            }

        }

        private void HandleCraftInteraction(Person actor, string craftedItemType ,string craftItemName)
        {
            switch (craftedItemType)
            {
                case "armor":
                    var actorInventory = actor.ListInventory();
                    if (actorInventory.Any(item => item.ItemType == ItemType.Iron))
                    {
                        this.AddToPerson(actor, new Armor(craftItemName));
                    }
                    break;
                case "weapon":
                    var actorInventory2 = actor.ListInventory();
                    if (actorInventory2.Any(item => item.ItemType == ItemType.Iron)
                        && actorInventory2.Any(item => item.ItemType == ItemType.Wood))
                    {
                        this.AddToPerson(actor, new Armor(craftItemName));
                    }
                    break;
                default:
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor, string gatheredItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;

            if (gatheringLocation != null)
            {
                var actorInventory = actor.ListInventory();
                foreach (var item in actorInventory)
                {
                    if (item.ItemType == gatheringLocation.RequiredItem)
                    {
                        var producedItem = gatheringLocation.ProduceItem(gatheredItemName);

                        this.AddToPerson(actor, producedItem);
                        break;
                    }
                }
            }
            
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person p = null;

            switch (personTypeString)
            {
                case "merchant":
                    p = new Merchant(personNameString, personLocation);
                    break;
                default: 
                    p = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;

            }
            return p;
        }
    }

}
