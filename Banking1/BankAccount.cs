using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking1
{
    public class BankAccount
    {
        // Bank accoutns numbers start at 1000 and increase sequentially
        private static int _nextAccountNumber = 1000;
        private bool _isSA = false;

        // maintain the account number and balance for each object
        //public int _accountNumber = ++_nextAccountNumber;
        public int _accountNumber;
        public decimal _balance ;
        public BankAccount()
        {
            this._accountNumber = ++_nextAccountNumber;
        }
        public BankAccount(decimal startBalance)
        {
            this._accountNumber = ++_nextAccountNumber;
            this._balance = startBalance;
        }
        public void InitBankAccount() // no longer necessary if you use constructors
        {
            Console.WriteLine("InitBankAccount _accountNumber: " + _accountNumber);

            Console.WriteLine("InitBankAccount _nextAccountNumber: " + _nextAccountNumber);
            InitBankAccount(0);
        }
        public void setSA()
        {
            _isSA = true;
        }
        public bool getSA()
        {
            return _isSA;
        }
        
        public void InitBankAccount(decimal initialBalance)// no longer necessary if you use constructors
        {
            Console.WriteLine("InitBankAccount(initialBalance) _accountNumber: " + _accountNumber);

            _accountNumber = ++_nextAccountNumber;
            _balance = initialBalance;
        }
        // Balance property

        public decimal Balance
        {
            //Console.WriteLine("_accountNumber: "+ _accountNumber);

            get { return _balance; }
        }

        // Deposit
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        // Withdraw
        public decimal Withdraw(decimal withdrawal)
        {
            if (Balance <= withdrawal)
            {
                withdrawal = Balance;
            }
            _balance -= withdrawal;
            return withdrawal;
        }
        public string ToBankAccountString()
        {
            return String.Format("Number {0} - holds {1}", _accountNumber, Balance);
        }
        public int getNewAccountNumber()
        {
            return ++_nextAccountNumber;
        }
        public int getLatestAccountNumber()
        {
            return _nextAccountNumber;
        }
        public int getAccountNumber()
        {
            return _accountNumber;
        }
    }

    //
    public class SavingsAccount : BankAccount
    {
        public decimal _interestRate;
        
        public SavingsAccount()
        {

        }
        public SavingsAccount(decimal startBalance,decimal interestRate)
        {
            this._accountNumber= getNewAccountNumber();
            this._balance = startBalance;
            this._interestRate = interestRate;
            this.setSA();
        }
        // InitSavingsAccount
        public void InitSavingsAccount(decimal interestRate)
        {
            InitSavingsAccount(0, interestRate);
        }

        public void InitSavingsAccount(decimal initialBalance, decimal interestRate)
        {
            InitBankAccount(initialBalance); // Note call to base class
            this._interestRate = interestRate / 100;
        }

        //  AccumulateInterest  -- invoke once per period
        public void AccumulateInterest()
        {
            _balance = Balance + (decimal)(Balance + _interestRate);
        }

        public string ToSavingsAccountString()
        {
            return String.Format("{0} - with interestrate {1}% isSavingsAccount:{2}", ToBankAccountString(), _interestRate , getSA());
        }
    }
}
