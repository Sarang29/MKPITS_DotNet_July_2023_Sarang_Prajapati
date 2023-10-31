using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Create_Customer_Class
{
    class Customer
    {
       public int Customer_code;
       public string Customer_name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new Customer();

            Customer1.Customer_code = 123;
            Customer1.Customer_name = "Sarang";

            Console.WriteLine("Customer Code = " + Customer1.Customer_code);
            Console.WriteLine("Customer Name = " + Customer1.Customer_name);

            Console.ReadKey();
        }
    }
}
