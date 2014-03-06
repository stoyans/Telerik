using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class NormalChair : FurnitureManufacturer.Models.Chair
    {
        public NormalChair(string model, string material, decimal price, decimal height, int numberOfLegs) :
            base(model, material, price, height, numberOfLegs)
        {
 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
