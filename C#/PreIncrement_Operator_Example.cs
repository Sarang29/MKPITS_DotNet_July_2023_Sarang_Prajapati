using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreIncrement_Operator_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = ++i;
            Console.WriteLine("Value of i = {0}, Value of j = {1}",i,j);
            Console.ReadKey();
        }
    }
}
