using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Company : FurnitureManufacturer.Interfaces.ICompany
    {

        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<Interfaces.IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value != null && value.Length > 4 && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid name for the company!");
                }
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length == 10 && CheckIfDigits(value) == true)
                {
                    this.registrationNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Registration number should contain only 10 digits!");
                }
            }
        }

        private bool CheckIfDigits(string registrationNum)
        {
            for (int i = 0; i < registrationNum.Length; i++)
            {
                if (!char.IsDigit(registrationNum[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public ICollection<Interfaces.IFurniture> Furnitures
        {
            get { return this.furnitures; }
            private set
            {
                this.furnitures = value;
            }
        }

        public void Add(Interfaces.IFurniture furniture)
        {
            Furnitures.Add(furniture);
        }

        public void Remove(Interfaces.IFurniture furniture)
        {
            Furnitures.Remove(furniture);
        }

        public Interfaces.IFurniture Find(string model)
        {

            foreach (var furniture in this.furnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }

            return null;
        }

        public string Catalog()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format(
                "{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            var ordered = furnitures.OrderBy(fur => fur.Price).ThenBy(fur => fur.Model);

            foreach (var furniture in ordered)
            {
                result.AppendLine(furniture.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
