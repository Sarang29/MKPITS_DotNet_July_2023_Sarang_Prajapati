using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UInt_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint b;
            Console.WriteLine("Note: Value Not Exceeding 4294967295");
            Console.WriteLine("Enter Number");
            b=Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Number = " + b);
            Console.ReadKey();
        }
    }
}
