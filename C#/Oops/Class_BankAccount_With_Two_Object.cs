using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_BankAccount_With_Two_Object
{
    class BankAccount
    {
        public int AccountNumber { get; set; }

        public string AccountHolderName { get; set; }

        public int Balance { get; set; }

        public void getdata(int AccountNumber,string AccountHolderName,int Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
        }

        public void display()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Account Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Balance : " + Balance);
        }

        public void Transaction(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }

        public void LatestBalance()
        {
            Console.WriteLine("Available Balance After Transaction Of Account Number {0} is {1}", AccountNumber, Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "Chetan";
            b1.Balance = 1000;
            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "David";
            b2.Balance = 2000;
            b2.display();

            Console.WriteLine("--------------------");
            Console.WriteLine("Updated Balance");
            Console.WriteLine("--------------------");

            b1.Transaction(b2);

            b1.LatestBalance();
            b2.LatestBalance();

            Console.ReadKey();
        }
    }
}
