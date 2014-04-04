using System;

namespace Bank
{
    public abstract class Customer
    {
        private string name;
        private string address;

        public Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

    }
}

