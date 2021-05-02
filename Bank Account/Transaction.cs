using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Transaction
    {
        private Account receiver;
        private Account sender;

        public string Additional { get; set; }
        public double Amu { get; set; }
        public void showTransactions()
        {
            Console.WriteLine(" Transaction type: {0}  ", Additional);
            Console.WriteLine(" Amount: " + Amu);
            if (Additional.ToLower().Equals("transfer"))
            {
                Console.WriteLine(" To: {0}({1})", receiver.AccName, receiver.AccNo);
            }

        }
        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amu, string additional)
        {
            this.sender = sender;
            this.receiver = receiver;
            Additional = additional;
            Amu = amu;
        }

    }
}
