using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Interface
{
    class Savings : Bank_IF
    {
        private decimal _balance;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if ((80 * _balance) / 100 < amount)
            {
                Console.WriteLine("Maximum limit cross!");
                return false;
            }
            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }
        }
    }
}