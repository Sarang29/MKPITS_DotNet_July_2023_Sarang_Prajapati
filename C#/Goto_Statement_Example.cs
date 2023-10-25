using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            
                goto even;
            
            Console.WriteLine("Odd Number");
                goto end;

        even:
            Console.WriteLine("Even Number");
        end:
            Console.WriteLine("bye");

            Console.ReadKey();
        }
    }
}
