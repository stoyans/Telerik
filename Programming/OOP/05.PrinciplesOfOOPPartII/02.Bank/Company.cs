using System;

namespace Bank
{
    public class Company : Customer
    {
        private string bulstat;

        public Company(string name, string address, string bulstat)
            : base(name, address)
        {
            this.Bulstat = bulstat;
        }

        public string Bulstat
        {
            get;
            set;
        }

    }
}

