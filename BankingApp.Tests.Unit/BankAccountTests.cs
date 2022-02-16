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
            account.MakeDeposit(5000, DateTime.Now, "5000 from Family");
            
            // then
            account.Balance.Should().Be(5000);
        }
    }
}
