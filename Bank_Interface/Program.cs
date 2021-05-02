using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_IF Savings = new Savings();
            Bank_IF Current = new Current();
            Bank_IF Overdraft = new Overdraft();

            Savings.Deposit(2100);
            Savings.Withdraw(500);
            Savings.Withdraw(1550);
            Savings.Deposit(1000);
            Savings.Withdraw(900);
            Savings.Withdraw(6789);


            Current.Deposit(20000);
            Current.Withdraw(2000);
            Current.Withdraw(18000);
            Current.Deposit(1234);
            Current.Withdraw(5678);

            Overdraft.Deposit(10000);
            Overdraft.Withdraw(500);
            Overdraft.Withdraw(11000);
            Overdraft.Withdraw(10000);
            Overdraft.Deposit(500);
        }
    }
}