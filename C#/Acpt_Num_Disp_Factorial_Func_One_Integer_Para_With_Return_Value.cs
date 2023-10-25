using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Disp_Factorial_Func_One_Integer_Para_With_Return_Value
{
    internal class Program
    {
        static int factorial(int num)
        {
            int fact = 1;

            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = factorial(number);
            Console.WriteLine("Factorial = {0}", result);

            Console.ReadKey();
        }
    }
}
