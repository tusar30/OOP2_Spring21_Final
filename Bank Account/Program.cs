using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("tusar", "111", 65000.0f);
            Account a2 = new Current("mahmudul", "112", 22000f);
            Account a3 = new Fixed("hasan", "123", 93000f, 2019, 14);

            a1.Deposit(10000);
            a1.Transfer(a2, 5000);
            a1.showAllTransaction();

            a2.ShowInfo();
            a2.Deposit(2000f);
            a2.Transfer(a2, 4000);
            a2.Withdraw(3000);
            a2.showAllTransaction();

            Customer customer = new Customer("rafik");
            Account ss = new SuperSavings("shafik", "200", 123f);
            ss.Deposit(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Alom", "007", 15000f, 7000);
            overdraft.Transfer(ss, 3000);
            overdraft.Deposit(12000);
            overdraft.ShowInfo();
            overdraft.showAllTransaction();
        }
    }
}
