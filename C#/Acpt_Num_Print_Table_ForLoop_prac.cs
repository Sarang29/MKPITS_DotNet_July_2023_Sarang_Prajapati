using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Print_table_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter;
            int res = 0;

            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());



            for (counter = 1; counter <= 10; counter++)
            {
                res = num * counter;
                Console.WriteLine("{0} * {1} = {2}", num, counter, res);
            }
            Console.ReadKey();
        }
    }
}
