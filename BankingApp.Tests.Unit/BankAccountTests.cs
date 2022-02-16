using FluentAssertions;
using Xunit;

namespace BankingApp.Tests.Unit
{
    public class BankAccountTests
    {
        [Fact]
        public void ShouldCreateBankAccountWithZeroBalance()
        {
            // given
            var account = new BankAccount("Martyn Hughes", 0);

            // when

            // then
            account.Balance.Should().Be(0);
        }
        
        [Fact]
        public void ShouldCreateBankAccountWithOpeningBalance()
        {
            // given
            var account = new BankAccount("Martyn Hughes", 100);

            // when

            // then
            account.Balance.Should().Be(100);
        }

        [Fact]
        public void ShouldAllowMakingADeposit()
        {
            // given
            var account = new BankAccount("Martyn Hughes", 100);

            // when
            account.MakeDeposit(5000);

            // then
            account.Balance.Should().Be(5100);
        }
    }
}
