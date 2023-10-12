using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULong_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong i;
            Console.WriteLine("Note: Value Not Exceeding 18,446,744,073,709,551,615");
            Console.WriteLine("Enter Number");
            i=Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Number = " + i);
            Console.ReadKey();
        }
    }
}
