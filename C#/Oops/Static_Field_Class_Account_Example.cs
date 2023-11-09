using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Field_Class_Account_Example
{
    class Account
    {
        public int accno;
        public string name;

        public static float rateofinterest = 7.7f;

        public Account(int accno,string name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " +rateofinterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(123,"Sarang");
            account1.display();

            Account account2 = new Account(456, "Chetan");
            account2.display();

            Console.ReadKey();

        }
    }
}
