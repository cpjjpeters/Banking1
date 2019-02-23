namespace HidingWithdrawal
{
    public class BankAccount
    {
        protected decimal _balance;
        private bool _isSavingsAccount;

        //public BankAccount(decimal initialBalance, bool isSavingsAccount)
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
            //_isSavingsAccount = isSavingsAccount;
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public decimal Withdraw(decimal amount)
        {
            //if (_isSavingsAccount)
            //{
            //    // skim of 1.5
            //    _balance -= 1.50M;
            //}
            decimal amountToWithdraw = amount;
            if (amountToWithdraw > Balance)
            {
                amountToWithdraw = Balance;
            }
            _balance -= amountToWithdraw;
            return amountToWithdraw;
        }
    }
}
