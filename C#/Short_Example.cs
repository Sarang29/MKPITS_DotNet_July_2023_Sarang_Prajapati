using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short c;
            Console.WriteLine("Note: Value Not Exceeding 32768 and -32768");
            Console.WriteLine("Enter Number");
            c=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Number = " + c);
            Console.ReadKey();
        }
    }
}
