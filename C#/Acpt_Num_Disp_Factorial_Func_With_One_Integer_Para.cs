using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Disp_Factorial_Func_With_One_Integer_Para
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
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            factorial(number);
            Console.ReadKey();
        }
    }
}
