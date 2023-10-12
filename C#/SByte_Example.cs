using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SByte_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte w=25;
            Console.WriteLine("Num = "+w);
            Console.WriteLine("Note: Value Not Exceeding More than 127 and -128");
            Console.WriteLine("Enter Number");
            w=Convert.ToSByte(Console.ReadLine());  
            Console.WriteLine("Number = " + w);
            Console.ReadKey();
        }
    }
}
