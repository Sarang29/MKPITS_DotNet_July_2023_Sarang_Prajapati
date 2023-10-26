using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_By_Value_Example_New
{
    internal class Program
    {
        static void display(int number)
        {
            number = 80;
            Console.WriteLine("Number Inside Method = " + number);
        }
        static void Main(string[] args)
        {
            int number = 50;
            display(number);
            Console.WriteLine("Number Inside Main = " + number);
            Console.ReadKey();
        }
    }
}
