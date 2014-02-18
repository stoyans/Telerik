using System;

namespace Bank
{
	public abstract class Account
	{
		private decimal balance;
		private decimal interestRatePerMonth;
		private Customer customer;
		
		public Account (Customer customer, decimal balance, decimal interest)
		{
			this.Balance = balance;
			this.InterestRate = interest;
			this.Customer = customer;
		}
		
		public decimal Balance
		{
			get
			{
				return this.balance;	
			}
			set
			{
				this.balance = value;
			}
		}
		
		public decimal InterestRate
		{
			get
			{
				return this.interestRatePerMonth;	
			}
			set
			{
				this.interestRatePerMonth = value;
			}
		}
		
		public Customer Customer
		{
			get { return this.customer; }
        	set { this.customer = value; }
		}
		
		public abstract decimal CalculaterInterest(int months);

	}
}

