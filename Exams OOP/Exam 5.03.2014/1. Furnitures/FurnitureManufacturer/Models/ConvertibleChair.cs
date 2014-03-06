using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class ConvertibleChair : NormalChair, FurnitureManufacturer.Interfaces.IConvertibleChair
    {
        private bool isConverted = false;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs) :
            base(model, material, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set 
            {
                this.isConverted = value;
            }
        }

        public void Convert()
        {
            if (IsConverted == true)
            {
                this.Height = 0.10m;
            }
            else
            {
                this.Height = Height;
            }
        }

        public override string ToString()
        {
            return base.ToString() + 
                string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", 
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
