/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    interface IManageAccount
    {
        public void showMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        void openAccount();
        void closeAccount();
    }
    interface IBankAccount
    {
        public static void showAnotherMessage()
        {
            Console.WriteLine("Transactions Here");
        }
        void deposit();
        void withdraw();
        void balance();
    }
    class SavingAccount : IManageAccount, IBankAccount
    {
        public void balance()
        {
            Console.WriteLine("Balance in Saving Account.");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Saving Account.");
        }

        public void deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Saving Account.");
        }

        public void withdraw()
        {
            Console.WriteLine("Withdraw from Saving Account.");
        }
    }
    class InterfaceExample
    {
        static void Main(string[] args)
        {
            IManageAccount manageAccount = new SavingAccount();
            manageAccount.showMessage();

            Console.WriteLine("*********************************");

            IBankAccount.showAnotherMessage();

            Console.WriteLine("*********************************");

            SavingAccount savingAccount = new SavingAccount();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();

            Console.WriteLine("*********************************");

            Console.ReadKey();
        }


    }
}
*/