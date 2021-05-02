using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {

        public Savings(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) { }
        public override void Transfer(Account acc, double amu)
        {
            if (amu <= Balance - 500)
            {
                acc.Balance += amu;
                Balance -= amu;
                Console.WriteLine("Your account transfer by {0} to the account {1}({2})", amu, acc.AccName, acc.AccNo);
                Transaction tr = new Transaction(this, acc, amu, "Transfer");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient balance!Min balance need 500.");
            }
        }
        public override void Withdraw(double amu)
        {
            if (amu <= Balance - 500)
            {
                Balance -= amu;
                Console.WriteLine("Your account debited by {0} .", amu);
                Transaction tr = new Transaction(this, this, amu, "Withdraw.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient balance! Min balance need 500.");
            }

        }
    }
}
