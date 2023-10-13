using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Integer_M_N_Print_Value_Of_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;

            Console.WriteLine("Enter Value of M");
            m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                Console.WriteLine("The Value of n=1");
            }
            else if(m == 0)
            {
                Console.WriteLine("The Value of n=0");
            }
            else if(m < 0)
            {
                Console.WriteLine("The Value of n=-1");
            }
            Console.ReadKey();
        }
    }
}
