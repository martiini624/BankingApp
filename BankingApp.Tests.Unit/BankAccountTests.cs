using FluentAssertions;
using System;
using Xunit;

namespace BankingApp.Tests.Unit
{
    public class BankAccountTests
    {
        [Fact]
        public void ShouldCreateBankAccountWithPostiveBalance()
        {
            // given
            var account = new BankAccount("Martyn Hughes", 10);

            // when

            // then
            account.Balance.Should().Be(10);
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
            var account = new BankAccount("Martyn Hughes", 10);

            // when
            account.MakeDeposit(50, DateTime.Now, "50 from Family");
            account.MakeDeposit(25, DateTime.Now, "Pocket Money");

            // then
            account.Balance.Should().Be(85);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void ShouldNotCreateBankAccountWithNonPostiveBalance(decimal amount)
        {
            try
            {
                // given
                var account = new BankAccount("Martyn Hughes", amount);

                // when

                // then
                Assert.Fail("Expected an exception");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ex.Message.Should().StartWith("Amount must be positive");
            }
        }
    }
}
