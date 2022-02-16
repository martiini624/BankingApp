using System;

namespace BankingApp
{
    public interface IBankAccount
    {
        string AccountNumber { get; }
        string AccountOwner { get; }
        decimal Balance { get; }
        void MakeDeposit(decimal amount, DateTime date, string note);
        void Withdrawal(decimal amount, DateTime date, string note);
    }
}
