using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cls_Bank_Cls_Acc_Both_Inher_in_Cls_Saving_Met_Dep_Wid
{
    interface Bank
    {
        string deposit(int actno, int amount);
        string withdrawl(int actno, int amount);
    }

    class Account
    {
        public int actno;
        public int balance = 1000;
        public int interest = 300;

        public string showbalance()
        {
            return "Balance : " + balance;
        }
    }

    class Saving : Account,Bank
    {
        public string deposit(int actno, int amount)
        {
            this.actno= actno;
            balance = balance + amount;
            return "Account Number : "+actno+ "\nAmount Deposited Successfully  : " + balance;
        }

        public string withdrawl(int actno,int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Account Number : "+actno+ "\nAmount Withdrawl Successfully : " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving b;
            b=new Saving();

            string res = b.deposit(1, 200);
            Console.WriteLine(res);

            res = b.withdrawl(2, 500);
            Console.WriteLine(res);

            Console.WriteLine(b.showbalance());


            Console.ReadKey();
        }
    }
}
