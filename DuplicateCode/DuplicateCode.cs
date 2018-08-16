using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCode
{
    class DuplicateCode
    {
        public string Name { get; set; }
        private decimal balance;

        public DuplicateCode(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }

        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount < balance)
            {
                Balance = Balance - withdrawAmount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount exceeded account balance");
            }
        }
    }
}
