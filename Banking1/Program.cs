using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking1
{
    
    class Program
    {
        public static void DirectDeposit(BankAccount ba, decimal pay)
        {
            ba.Deposit(pay);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("starting accountnumber at 1000; ");
            //create
            BankAccount bankrekening1 = new BankAccount(123M);
            Console.WriteLine("Account {0} with number {1}", bankrekening1.ToBankAccountString(), bankrekening1.getAccountNumber());
            BankAccount ba1 = new BankAccount();
            
            Console.WriteLine("starting accountnumber of {0} = {1} " ,"ba1", ba1.getAccountNumber());
            //ba1.InitBankAccount(100M);
            BankAccount ba2 = new BankAccount();
            //ba2.InitBankAccount(150M);
            DirectDeposit(ba2, 234M);
            Console.WriteLine("Account {0}", ba1.ToBankAccountString());
            Console.WriteLine("Account {0}", ba2.ToBankAccountString());
            // Now a saving
            //SavingsAccount sa1 = new SavingsAccount();
            //sa1.InitSavingsAccount(100M, 12.5M);
            SavingsAccount sa1 = new SavingsAccount(100M, 12.5M);
            SavingsAccount spaar1 = new SavingsAccount(555M, 10.0M);
            sa1.AccumulateInterest();
            Console.WriteLine("Account {0} ", sa1.ToSavingsAccountString());
            spaar1.AccumulateInterest();
            Console.WriteLine("Account {0} ", spaar1.ToSavingsAccountString());
            Console.Read();
        }
    }
}
