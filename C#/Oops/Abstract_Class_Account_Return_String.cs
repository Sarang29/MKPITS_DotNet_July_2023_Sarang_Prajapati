using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Account_Return_String
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;

        public abstract string deposit(int actno, int amount);

        public string ShowBalance()
        {
            return "Balance : " + balance;
        }
    }


    class Current : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Amount Deposited Without Interest in Current Account";
        }
    }

    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            int interest = 300;
            this.actno=actno;
            balance = balance + amount + interest;
            return "Amount Deposited With Interest in Saving Account";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (Current or Saving)");
            string acttype = Console.ReadLine();

            Account account = null;
            if (acttype == "Saving" || acttype == "saving")
            {
                account = new Saving();
            }
            else if (acttype == "Current" || acttype == "current")
            {
                account = new Current();
            }

            string res = account.deposit(actno,amount);
            Console.WriteLine("Account Number : " + actno);
            Console.WriteLine(res);

            res = account.ShowBalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
