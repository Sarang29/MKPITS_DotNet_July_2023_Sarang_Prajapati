using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string withdrawl(int amt)
        {
            string res = null;
            if (balance < amt)
            {
                return "Insufficient Fund In Account";
            }
            else
            {
                balance = balance - amt;
                return "Balance After Withdrawl : " + balance;
            }
        }

        public string showbalance()
        {
            return "Balance : " + balance;
        }
    }

        public class Saving : Account
        {
            int interest = 300;
            public override string deposit(int amt)
            {
                balance = balance + amt + interest;
                return "Deposited Amount With Interest : " + balance;
            }
        }

        public class Current:Account
        {
            public override string deposit(int amt)
            {
                balance = balance + amt;
                return "Balance After Deposit : " + balance;
            }
        }
}
