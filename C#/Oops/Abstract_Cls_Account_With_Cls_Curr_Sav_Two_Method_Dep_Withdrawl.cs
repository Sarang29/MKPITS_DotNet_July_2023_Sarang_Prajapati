using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Cls_Account_With_Cls_Curr_Sav_Two_Method_Dep_Withdrawl
{
    abstract class Account
    {
        public int balance = 1000;

        public abstract void Deposit(int amount);
        public abstract void Withdrawl(int amount);

        public void ShowBalance()
        {
            Console.WriteLine("Balance : "+balance);
        }
    }

    class Saving : Account
    {
        int interest = 300;
        public override void Deposit(int amount)
        {
            balance = balance + amount + interest;
            Console.WriteLine("Amount Deposited With Interest : " + balance);
        }
        public override void Withdrawl(int amount)
        {
            balance = balance - amount;
        }
    }

    class Current : Account
    {
        public override void Deposit(int amount)
        {
            balance= balance + amount;
        }

        public override void Withdrawl(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount Deposited WithOut Interest : " + balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = null;

            Console.WriteLine("Enter Amount");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (Current or Saving)");
            string acttype = Console.ReadLine();

            Console.WriteLine("Enter Deposit or Withdrawl");
            string transaction = Console.ReadLine();

            if(acttype == "Saving")
            {
                account = new Saving();
            }
            else if(acttype == "Current")
            {
                account = new Current();
            }

            if(transaction == "Deposit")
            {
                account.Deposit(amt);
            }
            else if(transaction == "Withdrawl")
            {
                account.Withdrawl(amt);
            }

            account.ShowBalance();

            Console.ReadKey();

        }
    }
}
