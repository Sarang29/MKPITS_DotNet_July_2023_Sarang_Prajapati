using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_and_Shared_Variable_Example
{
    internal class Program
    {
       static int num = 30;
        static void display()
        {
            int num = 10;
            Console.WriteLine("Number Inside Method = " + num);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("Number Inside Shared = " + num);
            Console.ReadKey();
        }
    }
}
