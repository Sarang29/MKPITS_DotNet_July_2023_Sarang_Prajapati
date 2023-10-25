using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Disp_Prime_Or_Not_One_Integer_Para
{
    internal class Program
    {
        static void prime(int num)
        {
            int counter;
            int flag=0;


            for(counter = 2; counter < num; counter++)
            {
                flag = 1;
                break;
            }
            if(flag == 0)
            {
                Console.WriteLine("It is Prime Number");
            }
            else
            {
                Console.WriteLine("It is Not a Prime Number");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());

            prime(number);
            Console.ReadKey();
        }
    }
}
