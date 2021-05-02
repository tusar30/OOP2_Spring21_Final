using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        public double Balance { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }

        Transaction[] transactions;
        public int sum { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double bal)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = bal;
            transactions = new Transaction[20];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account Number: " + AccNo);
            Console.WriteLine("Current Balance: " + Balance);
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("your account credited by {0}. Current balance: {1}", amount, Balance);
            transactions[sum++] = new Transaction(this, this, amount, "Deposit");
        }

        public void addTransaction(params Transaction[] transactionArr)
        {
            foreach (Transaction transaction in transactionArr)
            {
                this.transactions[sum++] = transaction;
            }
        }

        public void showAllTransaction()
        {
            Console.WriteLine("Transaction history : ({0}) ", AccName);

            for (int i = 0; i < sum; i++)
            {
                Console.Write(i + 1 + ". ");
                transactions[i].showTransactions();
            }
        }
        public abstract void Transfer(Account acc, double amu);
        public abstract void Withdraw(double amu);
    }
}
