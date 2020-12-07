using System;
using System.Collections.Generic;
using System.Text;

namespace BankExceptionHandling
{
   public class Account
    {
        private string _name;
        private decimal _balance;

        public Account()
        {
                
        }
        public Account(string name, decimal balance)
        {
            _name = name;
            if (balance <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_balance), _balance, "Balance should be greater than Zero");
            }
            _balance = balance;
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(_balance), _balance, "Balance should be greater than Zero");
                }
                _balance = value;
            }
        }

        // 
        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Amount should be positive");
            }
            _balance = _balance + amount;
        }

        // Balance should be greater than withdrawal amount
        public void WithDraw(decimal amount)
        {
            if(_balance < amount)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Balance should be greater than Amount");

            }
            _balance = _balance - amount;
        }
    }
}
