using System;

namespace BankingApp
{
    public class BankAccount : IBankAccount
    {
        public BankAccount(string accountOwner, decimal initalBalance)
        {
            this.AccountOwner = accountOwner;
            this.Balance = initalBalance;
            this.AccountNumber = "1234567890";
        }

        public string AccountOwner { get; private set; }

        public string AccountNumber { get; private set; }

        public decimal Balance { get; private set; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            throw new NotImplementedException();
        }

        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            throw new NotImplementedException();
        }
    }
}
