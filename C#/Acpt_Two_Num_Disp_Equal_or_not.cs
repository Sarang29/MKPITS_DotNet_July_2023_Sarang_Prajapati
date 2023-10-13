using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Two_Num_Disp_Equal_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
           
            Console.WriteLine("Enter Number 1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Both Number Are Equal");
            }
            else
            {
                Console.WriteLine("Both Number Are Not Equal");
            }
            Console.ReadKey();
        }
    }
}
