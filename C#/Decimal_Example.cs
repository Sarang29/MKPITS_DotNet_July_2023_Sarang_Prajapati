using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal i;
            Console.WriteLine("Enter Number");
            i=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Number = " + i);
            Console.ReadKey();
        }
    }
}
