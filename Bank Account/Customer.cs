using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Customer
    {
        public string Name { get; set; }
        Account[] accounts;
        public int cnt = 0;
        public Customer(string name)
        {
            Name = name;
            accounts = new Account[40];
        }

        public void AddAccount(params Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                this.accounts[cnt++] = acc;
            }
        }

        public void AccDetails()
        {
            Console.WriteLine("Customer name: " + Name);

            for (int i = 0; i < cnt; i++)
            {
                accounts[i].ShowInfo();
            }
        }

        public Account findAccount(string accNo)
        {
            Account acc = null;
            for (int i = 0; i < cnt; i++)
            {
                if (accNo.Equals(accounts[i].AccNo))
                {
                    acc = accounts[i];
                    break;
                }
            }
            return acc;
        }
    }
}
