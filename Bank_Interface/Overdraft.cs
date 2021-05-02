using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Interface
{
    class Overdraft : Bank_IF
    {
        private decimal _balance;
        private decimal over = 5000;
        private decimal check = 5000;
        public bool Deposit(decimal amount)
        {
            if (over < check)
            {
                decimal tt = check - over;
                decimal mn = Math.Min(amount, tt);
                over += mn;
                amount -= mn;
            }
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }
            else if ((_balance + over) >= amount)
            {
                amount -= _balance;
                _balance = 0;
                over -= amount;
                return true;

            }
            else
            {
                Console.WriteLine("Not Enough Balance!.");
                return false;
            }
        }
    }
}