using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("TestOne", 1.0m);
            Account account2 = new Account("TestTwo", 2.0m);

            Console.WriteLine($"{account1.Name}'s initial balance is: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s initial balance is: {account2.Balance:C}");

            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);
            Console.WriteLine($"{account1.Name}'s balance is: {account1.Balance:C}");

            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);
            Console.WriteLine($"{account2.Name}'s balance is: {account2.Balance:C}");
        }
    }
}
