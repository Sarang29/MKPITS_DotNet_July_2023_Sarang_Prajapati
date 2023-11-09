using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field_Class_Account_Example_New
{
    class Account
    {
        public int accno;
        public string name;
        public static float rateofinterest = 7.7f;

        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Account No : {0} , Account Name : {1}, Rate of Interest : {2}", accno, name, rateofinterest+"\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account.rateofinterest = 9.5f;

            Account account1 = new Account(123,"Sarang");
            account1.display();

            Account account2 = new Account(456, "Akash");
            account2.display();

            Console.ReadKey();
        }
    }
}
