using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class ExtendedHoldingPen : HoldingPen
    {
        public ExtendedHoldingPen() :
            base()
        {
            
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                case "Human":
                    var human = new Human(commandWords[2]);
                    this.InsertUnit(human);
                    break;
                default: base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            
        }
        
    }
}
