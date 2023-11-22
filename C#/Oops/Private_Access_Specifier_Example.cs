using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Access_Specifier_Example
{

    class Program
    {
        private int actno;
        private string accountholdername;

        private void getdata(int actno, string accountholdername)
        {
            this.actno = actno;
            this.accountholdername = accountholdername;
        }
        private void display()
        {
            Console.WriteLine("Account Number : " + actno);
            Console.WriteLine("Account Holder Name : " + accountholdername);
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.actno = 1;
            program.accountholdername = "Sarang";
            program.display();
            Console.ReadKey();
        }
    }
}

