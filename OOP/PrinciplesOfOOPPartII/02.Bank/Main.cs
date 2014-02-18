using System;

namespace Bank
{
	class MainClass
	{
		public static void Main ()
		{
			
			var client = new Individual("Pesho", "Sofia", 23);
			var account = new DepositAccount(client, 100, 2);
			Console.WriteLine (account.Balance);
			account.Deposit(100);
			Console.WriteLine (account.Balance);
			
			
			Console.WriteLine (account.CalculaterInterest(14));
			
			var account1 = new LoanAccount(new Individual("da","dwa", 9),5,5);
			Console.WriteLine (account1.CalculaterInterest(4));

		}
	}
}
