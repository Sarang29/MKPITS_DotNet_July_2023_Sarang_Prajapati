using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Object_of_Class_Using_Counter_Example
{
    class Account
    {
        public int accno;
        public string name;
        public int balance;
        public static int count = 0;

        public Account(int accno, string name, int balance)
        {
            this.accno = accno;
            this.name = name;
            this.balance = balance;
            count++;
        }

        public void display()
        {
            Console.WriteLine("Account Number : " + accno);
            Console.WriteLine("Account Holder Name : " + name);
            Console.WriteLine("Account Balance : " + balance+"\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1,"Sarang",50000);
            account1.display();

            Account account2 = new Account(2, "Akash", 40000);
            account2.display();

            Account account3 = new Account(3, "David", 30000);
            account3.display();

            Account account4 = new Account(4, "Sujit", 20000);
            account4.display();

            Account account5 = new Account(5, "Lucky", 10000);
            account5.display();

            Console.WriteLine("Total Objects in Class : "+Account.count);

            Console.ReadKey();
        }
    }
}
