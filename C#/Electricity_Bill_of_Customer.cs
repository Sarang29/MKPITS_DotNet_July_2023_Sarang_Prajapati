using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseElectricbill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id;
            float unit, total, charge = 0, bill;
            Console.WriteLine("Enter Customer Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Customer Id");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Unit Consume");
            unit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer Id:{0}\nCustomer Name:{1}\nUnit Consume:{2}\n", id, name, unit);

            if (unit < 200)
            {
                total = unit * 1.20f;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit : " + total);
            }
            else if (unit > 200 && unit < 400)
            {
                total = unit * 1.50f;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : " + total);
            }
            else if (unit > 400 && unit < 600)
            {
                total = unit * 1.80f;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : " + total);
            }
            else
            {
                total = unit * 2.00f;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : " + total);
            }
            if (total > 400)
            {
                charge = total * 0.15f;
                Console.WriteLine("Surchage Amount :  " + charge);

            }
            bill = total + charge;
            Console.WriteLine("Net Amount Paid By the Customer :" + bill);

            Console.ReadKey();
        }
    }
}