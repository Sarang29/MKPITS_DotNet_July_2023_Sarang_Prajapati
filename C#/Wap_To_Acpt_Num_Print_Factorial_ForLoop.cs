using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wap_To_Acpt_Num_Print_Factorial_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;

            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            for (int counter=num;counter>0;counter--)
            { 
                fact = fact * counter;
            }
            Console.WriteLine("Factorial = {0}", fact);
            Console.ReadKey();

        }
    }
}
