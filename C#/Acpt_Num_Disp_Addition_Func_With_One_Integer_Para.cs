using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Disp_Addition_Func_With_One_Integer_Para
{
    internal class Program
    {
        static void square(int num)
        {
            int sq = 0;
            while (num > 0)
            {
                sq = num * num;
                Console.WriteLine("Square : {0}", sq);
                break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            square(number);
            Console.ReadKey();
        }
    }
}
