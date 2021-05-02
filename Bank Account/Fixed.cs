using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Fixed : Account
    {
        public int openy { get; set; }
        public int fixedy { get; set; }

        public Fixed(string accName, string accNo, double bal, int openy, int fixedy) : base(accName, accNo, bal)
        {
            this.openy = openy;
            this.fixedy = fixedy;
        }

        public override void Transfer(Account acc, double amu)
        {
            int today = DateTime.Now.Year;
            if (today - openy > fixedy)
            {
                Balance -= amu;
                acc.Balance += amu;
                Transaction tr = new Transaction(this, acc, amu, "Transfer.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("This account is not valid!");
            }
        }
        public override void Withdraw(double amu)
        {
            int today = DateTime.Now.Year;
            if (today - openy > fixedy)
            {
                Balance -= amu;
                Transaction tr = new Transaction(this, this, amu, "Withdraw.");
                base.addTransaction(tr);
            }
            else
            {
                Console.WriteLine("This account is not valid!");
            }
        }
    }
}