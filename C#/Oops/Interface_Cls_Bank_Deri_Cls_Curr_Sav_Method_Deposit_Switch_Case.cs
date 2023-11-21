using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cls_Bank_Deri_Cls_Curr_Sav_Method_Deposit_Switch_Case
{
    interface Bank
    {
        string deposit(int actno, int amount);
    }

    class Saving : Bank
    {
        int actno;
        int balance = 1000;
        int interest = 300;

        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount + interest;
            Console.WriteLine("Amount Deposited Successfully With Interest");
            return "Account Number : " + actno + "\nBalance : " + balance;
        }
    }

    class Current : Bank
    {
        int actno;
        int balance = 1000;

        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            Console.WriteLine("Amount Deposited Successfully Without Interest");
            return "Account Number : " + actno + "\nBalance : " + balance;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = null;

            Console.WriteLine("Enter Account Number");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (Current or Saving");
            string acctype = Console.ReadLine();

            switch(acctype)
            {
                case "Saving":
                    bank = new Saving();
                    break;

                case "Current":
                    bank = new Current();
                    break;
            }

            string res = bank.deposit(actno, amount);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
