using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Overdraft : Account
    {
        public int lmt { get; set; }

        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance, int lmt) : base(accName, accNo, balance)
        {
            this.lmt = lmt;
        }
        public override void Transfer(Account acc, double amu)
        {
            if (amu <= Balance + lmt)
            {
                acc.Balance += amu;
                Balance -= amu;
                Transaction tr = new Transaction(this, acc, amu, "Transfer.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Not enough fund!");
            }
        }
        public override void Withdraw(double amu)
        {
            if (amu <= Balance + lmt)
            {
                Balance -= amu;
                Transaction tr = new Transaction(this, this, amu, "Withdraw");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Not enough fund!");
            }
        }
    }
}
