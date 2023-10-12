using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long d;
            Console.WriteLine("Note: Value Not Exceeding -9,223,372,036,854,775,808 to -9,223,372,036,854,775,854");
            Console.WriteLine("Enter Number");
            d=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Number = " + d);
            Console.ReadKey();
        }
    }
}
