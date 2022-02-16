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
            Transcation initalAmount = new Transcation(initalBalance, DateTime.Now, "Inital Balance");
            transactionHistory.Add(initalAmount);
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
            var deposit = new Transcation(amount, date, note);
            transactionHistory.Add(deposit);
        }

        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            throw new NotImplementedException();
        }
    }
}
