/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    abstract class ManageAccount
    {
        public void showMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        public abstract void openAccount();
        public abstract void closeAccount();
    }
    abstract class BankAccount : ManageAccount
    {
        public static void showAnotherMessage()
        {
            Console.WriteLine("Transactions in Account!!");
        }
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    class SavingAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        public override void closeAccount()
        {
            Console.WriteLine("Closing Saving Account.");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Saving Account");
        }

        public override void openAccount()
        {
            Console.WriteLine("Opening Saving Account.");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }
    }

    class CurrentAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Current Account.");
        }

        public override void closeAccount()
        {
            Console.WriteLine("Closing Current Account.");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Current Account.");
        }

        public override void openAccount()
        {
            Console.WriteLine("Opening Current Account.");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdraw from Current Account.");
        }
    }

    class AbstractExample
    {
        static void Main(string[] args)
        {
            ManageAccount manageAccount = new SavingAccount();
            manageAccount.showMessage();

            Console.WriteLine("*********************************");

            BankAccount.showAnotherMessage();

            Console.WriteLine("*********************************");

            SavingAccount savingAccount = new SavingAccount();
            savingAccount.showMessage();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();

            Console.WriteLine("*********************************");

            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.openAccount();
            currentAccount.deposit();
            currentAccount.withdraw();
            currentAccount.balance();
            currentAccount.closeAccount();

            Console.ReadKey();
        }
    }
}
*/