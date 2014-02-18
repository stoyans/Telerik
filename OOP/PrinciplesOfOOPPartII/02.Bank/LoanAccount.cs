using System;

namespace Bank
{
	public class LoanAccount : MortgageAccount
	{

		public LoanAccount (Customer customer, decimal balance, decimal interest)
			:base(customer, balance, interest)
		{
			
		}
		
		public override decimal CalculaterInterest (int months)
		{
			if (this.Customer is Individual && months > 3) 
			{
				return months*InterestRate;
			}
			if (this.Customer is Company && months > 2) 
			{
				return months*InterestRate;
			}
			return 0;

		}
	}
}

