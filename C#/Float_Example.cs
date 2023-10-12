using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p;
            Console.WriteLine("Enter Number");
            p=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Number = " + p);
            Console.ReadKey();
        }
    }
}
