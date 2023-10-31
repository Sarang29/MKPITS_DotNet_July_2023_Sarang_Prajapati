using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Customer_Input_CustCode_CustName_Form_User
{
    class Customer
    {
        int customer_code;
        string customer_name;

        public void getdata(int customer_code, string customer_name)
        {
            this.customer_code = customer_code;
            this.customer_name = customer_name;
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

            Console.WriteLine("Enter Customer Code & Name");
            int cc = Convert.ToInt32(Console.ReadLine());
            string cn = Console.ReadLine();

            customer1.getdata(cc, cn);
            customer1.displaydata();

            Console.ReadKey();
        }
    }
}
