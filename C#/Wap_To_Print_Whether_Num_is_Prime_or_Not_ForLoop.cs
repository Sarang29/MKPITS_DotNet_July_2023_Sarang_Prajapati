using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wap_To_Print_Whether_Num_is_Prime_or_Not_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter;
            int flag = 0;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
            }
                    if(flag==0) 
                    {
                        Console.WriteLine("Prime Number");
                    }
                    else
                    {
                         Console.WriteLine("Not a Prime Number");
                    }
            Console.ReadKey();
        }
           
        }
}
