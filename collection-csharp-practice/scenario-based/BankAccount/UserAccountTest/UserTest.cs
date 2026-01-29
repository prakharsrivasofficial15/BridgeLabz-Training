using System;
using System.Reflection;
using NUnit.Framework;
using BankAccount.UserAccounts;
using System.Runtime.CompilerServices;
namespace UserAccountTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;
        [SetUp]
        public void Setup()
        {
            user = new User();
        }

        [Test]
        public void Test_Deposit_ValidAmount()
        {
            user.Deposit(1000.00M);
            Assert.That(user.GetBalance(), Is.EqualTo(11000.00M));
        }
        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            Assert.Throws<NotValidAmountException>(()=>user.Deposit(-1000.00M) );
        }
        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            user.Withdraw(1000.00M);
            Assert.That(user.GetBalance(),Is.EqualTo(9000.00M));
        }
        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            Assert.Throws<NotSufficentFunds>(()=>user.Withdraw(11000.00M) );
        }
    }
}


