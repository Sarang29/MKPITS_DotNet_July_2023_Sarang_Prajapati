using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Accno_Amount_Func_Deposit_Withdrawl_Func_With_Three_Para
{
    internal class Program
    {
        static int bank(int accno, int amount, int bal = 1000)
        {
            int res = bal + amount;
            Console.WriteLine("Balance With Deposit : {0}", res);

            res = bal - amount;
            Console.WriteLine("Balance With Withdraw : {0}", res);

            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Account Number : ");
            int acntno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount : ");
            int amnt = Convert.ToInt32(Console.ReadLine());

            int balance = 1000;

            int result = bank(acntno, amnt, balance);
            

            Console.ReadKey();
        }
    }
}
