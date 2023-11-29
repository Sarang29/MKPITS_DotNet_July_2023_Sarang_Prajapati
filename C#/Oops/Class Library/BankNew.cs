using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNew
{
    abstract public class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string withdrawl(int amt)
        {
            string res = null;
            if (balance > amt)
            {
                res="Insufficient Fund In Account";
            }
            else
            {
                balance = balance - amt;
                res= "Withdrawl balance : "+balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "Balance : " + balance;
        }
    }

    public class Saving:Account
    {
        public int interest = 300;
        public override string deposit(int amt)
        {
            balance = balance + amt + interest;
            return "Balance After Deposit With Interest : " + balance;
        }
    }

    public class Current : Account
    {
        public override string deposit(int amt)
        {
            balance = balance + amt;
            return "Balance Deposited Without Interest : " + balance;
        }
    }
}
