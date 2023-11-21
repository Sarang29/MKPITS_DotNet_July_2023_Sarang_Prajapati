using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Cls_Bank_Deri_Cls_Saving_Method_Deposit
{
    interface Bank
    {
        string Deposit(int actno, int amount);
    }

    class Saving : Bank
    {
        int actno;
        int balance = 1000;

        public string Deposit(int actno,int amount)
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
            Bank bank;
            bank = new Saving();
            string res = bank.Deposit(123, 500);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
