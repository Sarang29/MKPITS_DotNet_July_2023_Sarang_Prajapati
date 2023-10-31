using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Customer_With_Two_Methods_Get_Disp_Data
{
    class Customer
    {
        int customer_code;
        string customer_name;

        public void getdata(int cc,string cn)
        {
            customer_code = cc;
            customer_name = cn;
        }

        public void displaydata()
        {
            Console.WriteLine("Customer Code = " + customer_code);
            Console.WriteLine("Customer Name = " + customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.getdata(123, "David");
            customer1.displaydata();

            Console.ReadKey();
        }
    }
}
