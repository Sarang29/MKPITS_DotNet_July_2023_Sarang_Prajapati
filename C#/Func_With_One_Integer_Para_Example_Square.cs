using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_With_One_Integer_Para_Example_Square
{
    internal class Program
    {
        static void square(int num)
        {
            int sq = 1;

            while (num > 0)
            {
                sq = num * num;
                Console.WriteLine("Square : {0}", sq);
                break;
            }
        }
        static void Main(string[] args)
        {
            square(9);
            Console.ReadKey();
        }
    }
}
