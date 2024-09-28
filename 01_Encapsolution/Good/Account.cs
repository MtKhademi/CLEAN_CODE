using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapulation.Good
{
    internal class Account
    {
        private double _balance;
        public double Balance => _balance;

        public Account(int balance = 0)
        {
            Diposit(balance);
        }

        public void Diposit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException();

            _balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException();

            if (amount >= _balance)
                throw new ArgumentOutOfRangeException();

            _balance -= amount;
        }

        public override string ToString() => $"Balance is {Balance}";
    }
}
