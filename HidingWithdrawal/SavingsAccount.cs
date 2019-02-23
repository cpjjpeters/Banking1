using System;

namespace HidingWithdrawal
{
    public class SavingsAccount : BankAccount
    {
        public decimal _interestRate;
        public SavingsAccount(decimal initialBalance, decimal interestRate): base(initialBalance)
        {
            _interestRate = interestRate / 100;
        }
        public void AccumulateInterest()
        {
            _balance = Balance + (Balance * _interestRate);
        }
        public decimal Withdraw(decimal withdrawal)
        {
            // take 1.5
            base.Withdraw(1.5M);
            Console.WriteLine("base.Withdraw finished");
            return base.Withdraw(withdrawal);
        }
    }
}
