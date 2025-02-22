using System;
namespace BankingSystem
{
    public class BankAccount
    {
        private double _balance;

        public BankAccount(double initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");
            
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds.");

            _balance -= amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}

using NUnit.Framework;
using BankingSystem;
using System;
namespace BankingTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount(100);
        }
        [Test]
        public void TestDeposit_UpdatesBalanceCorrectly()
        {
            _account.Deposit(50);
            Assert.That(_account.GetBalance(), Is.EqualTo(150));
        }
        [Test]
        public void TestWithdraw_UpdatesBalanceCorrectly()
        {
            _account.Withdraw(40);
            Assert.That(_account.GetBalance(), Is.EqualTo(60));
        }
        [Test]
        public void TestWithdraw_ThrowsException_IfInsufficientFunds()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(200));
        }

        [Test]
        public void TestDeposit_ThrowsException_IfNegativeAmount()
        {
            Assert.Throws<ArgumentException>(() => _account.Deposit(-10));
        }

        [Test]
        public void TestWithdraw_ThrowsException_IfNegativeAmount()
        {
            Assert.Throws<ArgumentException>(() => _account.Withdraw(-10));
        }
    }
}
