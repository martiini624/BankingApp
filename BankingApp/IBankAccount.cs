namespace BankingApp
{
    public interface IBankAccount
    {
        string AccountNumber { get; }
        string AccountOwner { get; }
        decimal Balance { get; }
        void MakeDeposit(decimal amount);
        void Withdrawal(decimal amount);
    }
}
