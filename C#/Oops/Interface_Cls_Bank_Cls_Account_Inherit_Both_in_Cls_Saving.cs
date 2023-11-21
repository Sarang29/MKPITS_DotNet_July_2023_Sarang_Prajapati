using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cls_Bank_Cls_Account_Inherit_Both_in_Cls_Saving
{
    interface Bank
    {
        string deposit(int actno, int amount);
    }

    class Account
    {
        public int actno;
        public int balance = 1000;
    }

    class Saving : Account,Bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Account Number : " + actno + "\nBalance : " + balance;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;

            Console.WriteLine("Enter Account Number ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount ");
            int amount = Convert.ToInt32(Console.ReadLine());

            b = new Saving();
            string res = b.deposit(actno, amount);
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
