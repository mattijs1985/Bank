using System;

namespace Howest.Cia.Bank.Core
{
    public class Account
    {
        public decimal Balance { get; private set; }
        
        public Account()
        {
            Balance = 500;
        }

        public Account(decimal initialAmount)
        {
            Balance = initialAmount;
        }

        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
