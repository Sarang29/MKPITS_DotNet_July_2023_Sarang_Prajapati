using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_With_One_Integer_Parameter_Example
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact = 1;

            while (num > 0)
            {
                fact = fact * num;
                num = num - 1;
            }
            Console.WriteLine("Factorial : {0}", fact);

        }
        static void Main(string[] args)
        {
            factorial(6);
            Console.ReadKey();
        }
    }
}
