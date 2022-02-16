using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingApp
{
    public class BankAccount : IBankAccount
    {
        private List<Transcation> transactionHistory = new List<Transcation>();

        public BankAccount(string accountOwner, decimal initalBalance)
        {
            this.AccountOwner = accountOwner;
            this.AccountNumber = "1234567890";
            this.MakeDeposit(initalBalance, DateTime.Now, "Inital Balance");
        }

        public string AccountOwner { get; private set; }

        public string AccountNumber { get; private set; }

        public decimal Balance
        {
            get
            {
                return transactionHistory.Sum(item => item.Amount);
            }
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }

            var deposit = new Transcation(amount, date, note);
            transactionHistory.Add(deposit);
        }

        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            throw new NotImplementedException();
        }
    }
}
