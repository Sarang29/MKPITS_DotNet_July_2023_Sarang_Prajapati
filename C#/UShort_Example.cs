using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UShort_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort p;
            Console.WriteLine("Enter Number");
            p=Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Number = " + p);
            Console.ReadKey();
        }
    }
}
