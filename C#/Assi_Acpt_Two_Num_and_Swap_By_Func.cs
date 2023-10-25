using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_Acpt_Two_Num_and_Swap_By_Func
{
    internal class Program
    {
        static void swap(int ab,int ac)
        {
            ab = ab - ac;
            ac = ab + ac;
            ab = ac - ab;

            Console.WriteLine("Now 1st Number is {0}", ab);
            Console.WriteLine("Now 2nd Number is {0}", ac);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int num2=Convert.ToInt32(Console.ReadLine());

            swap(num1, num2);
            Console.ReadKey();
        }
    }
}
