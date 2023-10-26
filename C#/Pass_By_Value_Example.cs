using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_By_Value_Example
{
    internal class Program
    {
        static void display(int num)
        {
            num = 90;
            Console.WriteLine("Number = " + num);
        }
        static void Main(string[] args)
        {
            int number = 10;
            display(number);
            Console.WriteLine("Number from Main = " + number);
            Console.ReadKey();
        }
    }
}
