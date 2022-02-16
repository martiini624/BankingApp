using System;
using System.Collections.Generic;

namespace BankingApp
{
    public class BankAccount : IBankAccount
    {
        public BankAccount(string accountOwner, decimal initalBalance)
        {
            this.AccountOwner = accountOwner;
            this.Balance = initalBalance;
            this.AccountNumber = "1234567890";
            this.Transcations = new List<Transcation>();
        }

        public string AccountOwner { get; private set; }

        public string AccountNumber { get; private set; }

        public decimal Balance { get; private set; }
        private List<Transcation> Transcations { get; set; }

        public void MakeDeposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdrawal(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
