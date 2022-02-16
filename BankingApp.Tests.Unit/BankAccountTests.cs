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
    }
}
