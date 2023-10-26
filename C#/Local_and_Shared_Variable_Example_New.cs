using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_and_Shared_Variable_Example_New
{
    internal class Program
    {
        static int num = 90;
        static void Display()
        {
            int num = 10;
            Console.WriteLine("Number Inside Method = " + num);
        }
    
        static void Main(string[] args)
        {
            Display();
            Console.WriteLine("Number Inside Shared = " + num);
            Console.ReadKey();
        }
    }
}
