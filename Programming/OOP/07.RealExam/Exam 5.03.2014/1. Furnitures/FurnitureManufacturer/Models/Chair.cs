using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Chair : FurnitureManufacturer.Furniture, FurnitureManufacturer.Interfaces.IChair
    {
        private int numberOfLegs;

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs) :
            base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set
            {
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());
            result.Append(", Legs: {0}");
            return string.Format(result.ToString(), this.NumberOfLegs);
        }

    }
}
