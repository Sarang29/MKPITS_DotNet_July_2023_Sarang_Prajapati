using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Example_Class_Program
{
    internal class Program
    {
        void dislpay()
        {
            Console.WriteLine("Hello From Class Program");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.dislpay();
            Console.ReadKey();
        }
    }
}
