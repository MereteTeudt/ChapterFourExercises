using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCode
{
    class DuplicateCodeTest
    {
        static void Main(string[] args)
        {
                DuplicateCode account1 = new DuplicateCode("TestOne", 1.0m);
                DuplicateCode account2 = new DuplicateCode("TestTwo", 2.0m);

                DisplayAccount(account1);
                DisplayAccount(account2);

                Console.Write("\nEnter deposit amount for account1: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Adding {depositAmount:C} to account1 balance\n");
                account1.Deposit(depositAmount);
                DisplayAccount(account1);

                Console.Write("\nEnter deposit amount for account2: ");
                depositAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Adding {depositAmount:C} to account2 balance\n");
                account2.Deposit(depositAmount);
                DisplayAccount(account2);

                Console.Write("\nEnter withdrawal amount for account2: ");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Withdrawing {depositAmount:C} from account2 balance\n");
                account2.Withdraw(withdrawalAmount);
                DisplayAccount(account2);
                string x = Console.ReadLine();
                Console.Write(x);
        }
        static void DisplayAccount(DuplicateCode accountToDisplay)
        {
            Console.WriteLine($"Account name: {accountToDisplay.Name}\nAccount balance: {accountToDisplay.Balance}");
        }
    }
}
