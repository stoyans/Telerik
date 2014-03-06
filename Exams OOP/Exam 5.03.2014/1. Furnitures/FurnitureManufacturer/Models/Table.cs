using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class Table : Furniture, FurnitureManufacturer.Interfaces.ITable
    {

        private decimal length;
        private decimal width;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width):
            base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get { return this.length; }
            private set
            {
                //if (value < 1)
                //{
                //    throw new ArgumentOutOfRangeException("Table length must be positive!");
                //}
                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            private set 
            {
                //if (value < 1)
                //{
                //    throw new ArgumentOutOfRangeException("Table length must be positive!");
                //}
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return Length * Width;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", 
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
    }
}
