using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice_1
{
    internal class BankAccount
    {
        //Fields
        string _accountNumber;
        string _customerName;
        double _balance;

        //Constructor
        public BankAccount(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        //Properties
        public string AccountNumber { get => _accountNumber;}
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance; set => _balance = value; }

        //Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public override string ToString()
        {
            return $"{_accountNumber} - {_customerName} - Current balance: {_balance}";
        }
    }
}
