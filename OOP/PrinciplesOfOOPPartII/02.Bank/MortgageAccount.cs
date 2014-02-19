using System;

namespace Bank
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {

        }

        public decimal Deposit(int deposit)
        {
            return Balance += deposit;
        }

        public override decimal CalculaterInterest(int months)
        {
            if (this.Customer is Individual && months > 6)
            {
                return months * InterestRate;
            }
            else if (this.Customer is Company && months < 13)
            {
                return months * InterestRate / 2;
            }

            return 0;

        }
    }
}

