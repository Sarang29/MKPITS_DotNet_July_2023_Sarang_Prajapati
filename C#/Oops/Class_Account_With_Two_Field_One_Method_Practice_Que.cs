using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Account_With_Two_Field_One_Method_Practice_Que
{
    class Account
    {
        int accno;
        string name;
        
        public void getdata(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Account Number : " + accno);
            Console.WriteLine("Account HolderName : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.getdata(123, "Sarang");
            account.display();

            Console.ReadKey();
        }
    }
}
