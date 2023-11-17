using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTIme_PolyMorphism_Class_Current_Inherit_From_Class_Account
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual string deposit(int actno, int amount)
        {
            return "Deposit Method Of BaseClass";
        }

        public string showbalance()
        {
            return "Account Balance : " + balance;
        }
    }

    class Current : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Balance in Current Account : " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Current();

           string res= a1.deposit(1, 200);
            Console.WriteLine("Account Number is : " + a1.actno);
            Console.WriteLine(res);
            res = a1.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
