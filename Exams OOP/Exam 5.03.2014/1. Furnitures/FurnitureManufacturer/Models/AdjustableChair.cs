using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class AdjustableChair : NormalChair, FurnitureManufacturer.Interfaces.IAdjustableChair
    {

        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs):
            base(model, material, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
