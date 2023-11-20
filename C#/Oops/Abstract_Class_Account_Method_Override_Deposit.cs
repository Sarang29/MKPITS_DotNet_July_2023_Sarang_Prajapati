using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Account_Method_Override_Deposit
{
    abstract class Account
    {
        public abstract void deposit();  
    }

    class Saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello From Saving Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.deposit();

            Console.ReadKey();
        }
    }
}
