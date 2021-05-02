using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SuperSavings : Account
    {
        public double open { get; set; }
        public SuperSavings(string accName, string accNo, double bal) : base(accName, accNo, bal)
        {
            this.open = bal;
        }
        public override void Transfer(Account acc, double amu)
        {
            if (amu <= Balance - (open * 20 / 100))
            {
                acc.Balance += amu;
                Balance -= amu;
                Transaction tr = new Transaction(this, acc, amu, "Transfer.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Not Enough fund!Min amount needed: " + open * 20 / 100);
            }
        }
        public override void Withdraw(double amu)
        {
            if (amu <= Balance - (open * 20 / 100))
            {
                Balance -= amu;
                Transaction tr = new Transaction(this, this, amu, "Withdraw.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("Not Enough fund!Min amount needed: " + open * 20 / 100);
            }
        }
    }
}
