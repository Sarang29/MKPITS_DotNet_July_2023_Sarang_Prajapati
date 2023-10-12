using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b;
            Console.WriteLine("Enter True & False");
            b=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ans = " + b);
            Console.ReadKey();
        }
    }
}
