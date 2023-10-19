using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_5_Num_Print_Sum_of_5_Num_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            for(int counter = 1; counter <= 5; counter++)
            {
                Console.Write("Enter Number : ");
                num=Convert.ToInt32(Console.ReadLine());

                sum=sum+counter;
                
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
