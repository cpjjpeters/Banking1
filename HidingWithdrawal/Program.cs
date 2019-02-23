using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingWithdrawal
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba;
            SavingsAccount sa;

            ba = new BankAccount(200M);
            ba.Withdraw(100M);

            sa = new SavingsAccount(222M, 12);
            sa.Withdraw(100M);

            Console.WriteLine("When invode directly:");
            Console.WriteLine("BankAccount balance is {0}", ba.Balance);
            Console.WriteLine("SavingsAccount balance is {0}", sa.Balance);

            Console.WriteLine("");
        }
    }
}
