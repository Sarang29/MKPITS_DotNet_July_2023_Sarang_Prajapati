using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Num_Print_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i, sum;
            
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=10;i++)
            {
                sum = num * i;   
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
