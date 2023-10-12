using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            Console.WriteLine("Enter Number");
            b=Convert.ToByte(Console.ReadLine());  //Value Not Exceeding More than 255//
            Console.WriteLine("Number = "+b);
            Console.ReadKey();
        }
    }
}
