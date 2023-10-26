using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Variable_Example
{
    internal class Program
    {
        static void display(ref int num)
        {
            num = 90;
            Console.WriteLine("Number Inside Method = " + num);
        }
        static void Main(string[] args)
        {
            int num = 50;
            display(ref num);
            Console.WriteLine("Number Inside Main = " + num);
            Console.ReadKey();
        }
    }
}
