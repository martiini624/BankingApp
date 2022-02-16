using FluentAssertions;
using System;
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
        public void ShouldMakeDeposit()
        {
            // given
            var account = new BankAccount("Martyn Hughes", 0);

            // when
            account.MakeDeposit(50, DateTime.Now, "50 from Family");
            account.MakeDeposit(25, DateTime.Now, "Pocket Money");

            // then
            account.Balance.Should().Be(75);
        }
    }
}
