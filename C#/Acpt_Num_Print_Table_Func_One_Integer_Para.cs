using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Print_Table_Func_One_Integer_Para
{
    internal class Program
    {
        static void table(int num)
        {
            int res = 0;
            int counter = 1;
            while (counter <= 10)
            {
                res = num * counter;
                Console.WriteLine("{0} * {1} = {2}",num,counter,res);
                counter++;
            }
        }
        static void Main(string[] args)
        {
            table(5);
            Console.ReadKey();
        }
    }
}
