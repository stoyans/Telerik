using System;

namespace Bank
{
    class MainClass
    {
        public static void Main()
        {

            var client = new Individual("Client", "Sofia", 23);
            var account = new DepositAccount(client, 1000, 2);
            Console.WriteLine(account.Balance);
            //making a deposit of 100
            account.Deposit(100);
            //money after the deposit
            Console.WriteLine(account.Balance);
            //interest after 14months
            Console.WriteLine(account.CalculaterInterest(14));
            //making a withdraw
            account.Withdraw(500);
            Console.WriteLine(account.Balance);

            var account1 = new LoanAccount(new Company("ComapanySoft", "Varna", "1024443"), 10400, 7);
            //interest after 6months
            Console.WriteLine(account1.CalculaterInterest(6));

        }
    }
}
