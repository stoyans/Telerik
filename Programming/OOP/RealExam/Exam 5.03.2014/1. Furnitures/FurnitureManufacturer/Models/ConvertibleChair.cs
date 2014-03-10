using FurnitureManufacturer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class ConvertibleChair : Chair, FurnitureManufacturer.Interfaces.IConvertibleChair
    {

        private decimal nonConvertedHeight;
        private bool isconverted = false;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs) :
            base(model, material, price, height, numberOfLegs)
        {
            this.nonConvertedHeight = height;
        }

        public bool IsConverted
        {
            get {return this.isconverted;}
            private set { this.isconverted = value; }
        }

        public void Convert()
        {
            if (!IsConverted)
            {
                this.Height = 0.10m;
            }
            else
            {
                this.Height = this.nonConvertedHeight;
            }

           this.IsConverted = !this.IsConverted;
        }

       public override string ToString()
       {
           var result = new StringBuilder(base.ToString());
           result.Append(", State: {0}");
           return string.Format(result.ToString(), this.IsConverted ? "Converted" : "Normal");
       }
    }
}
