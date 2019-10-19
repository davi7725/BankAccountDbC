using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountDbC
{
    class Account
    {
        private string _name;
        private double _balance;

        public Account(string name, double balance)
        {
            Contract.Requires(!string.IsNullOrEmpty(name));
            Contract.Requires(balance >= 0);

            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            Contract.Invariant(!string.IsNullOrEmpty(_name));
            Contract.Invariant(_balance >= 0);

            Contract.Requires(amount > 0);

            Contract.Ensures(_balance == Contract.OldValue(_balance) + amount);
            
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            Contract.Invariant(!string.IsNullOrEmpty(_name));
            Contract.Invariant(_balance >= 0);

            Contract.Requires(amount > 0);

            Contract.EnsuresOnThrow<Exception>(
                Contract.OldValue(_balance) == _balance
                );

            if(_balance < amount)
                throw new Exception("Amount Exceeded!");

            _balance -= amount;
        }

        public double GetCurrentAmount()
        {
            return _balance;
        }
        
    }
}
