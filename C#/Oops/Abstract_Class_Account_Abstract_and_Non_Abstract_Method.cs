using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Account_Abstract_and_Non_Abstract_Method
{
    abstract class Account
    {
        public abstract void deposit();

        public void showbalance()
        {
            Console.WriteLine("Account Balance");
        }
    }

    class Saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Deposited Balance");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();

            act.showbalance();
            act.deposit();

            Console.ReadKey();
        }
    }
}
