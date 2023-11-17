using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Class_Current_Saving_Inherit_From_Account
{
    class Account
    {
        public int bal = 1000;
        public string accname;
    }

    class Current:Account
    {
        int interest = 500;
        public void deposit(int amt)
        {
            bal = bal + amt + interest;
            Console.WriteLine("Balance of Current Account : " + bal);
        }
    }

    class Saving : Account
    {
        public void deposit(int amt)
        {
            bal=bal+ amt;
            Console.WriteLine("Balance of Saving Account : " + bal);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Current c1= new Current();
            c1.deposit(200);
            c1.accname = "Sarang";

            Saving s1 = new Saving();
            s1.deposit(400);
            s1.accname = "Ashwin";

            Console.ReadKey();
        }
    }
}
