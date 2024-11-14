using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        private decimal balance;

        public AccountOwner Owner { get;}
        public AccountAdmin Admin { get;}

        public Account(AccountOwner owner, AccountAdmin admin, decimal initialBalance)
        {
            Owner = Owner;
            Admin = admin;
            balance = initialBalance >= 100 ? initialBalance : 100;
            Console.WriteLine("Hej, din konto er oprettet");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            PrintBalanceUpdate();
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                PrintBalanceUpdate();
            }
            else
            {
                Console.WriteLine("Ikke nok penge på kontoen til at gennemføre hævningen.");
            }
        }

        private void PrintBalanceUpdate()
        {
            Console.WriteLine($"Din konto er blevet opdateret. Der står nu kr. {balance}");
        }
    }
}
