using System;

namespace Bank
{
	public class DepositAccount : Account, IDepositable, IWithDrawable
	{
		
		public DepositAccount (Customer customer, decimal balance, decimal interest)
			:base(customer, balance, interest)
		{
			
		}
		
		public decimal Deposit(int deposit)
		{
			return Balance += deposit;
		}
		
		public decimal Withdraw(int withdraw)
		{
			return Balance -= withdraw;
		}

		public override decimal CalculaterInterest (int months)
		{
			if (Balance < 1000) 
			{
				return 0;	
			}
			else
			{
				return InterestRate*months;
			}
		}
	}
}

