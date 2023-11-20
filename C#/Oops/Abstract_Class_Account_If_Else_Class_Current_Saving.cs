using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Account_If_Else_Class_Current_Saving
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;

        public abstract void deposit(int amount);

        public void showbalance()
        {
            Console.WriteLine("Account Number : {0} \nAccount Balance : {1}",actno,balance);
        }
    }

    class Current : Account
    {
        public override void deposit(int amount)
        {
            balance = balance + amount;
        }
    }

    class Saving : Account
    {
        public override void deposit(int amount)
        {
            int interest = 200;
            balance = balance + amount + interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number");
            int acctno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (Current or Saving)");
            string acttype = Console.ReadLine();

            Account act = null;
            if(acttype=="Saving")
            {
                act = new Saving();
            }
            else if(acttype=="Current")
            {
                act = new Current();
            }

            act.actno = acctno;
            act.deposit(amt);
            act.showbalance();

            Console.ReadKey();
        }
    }
}
