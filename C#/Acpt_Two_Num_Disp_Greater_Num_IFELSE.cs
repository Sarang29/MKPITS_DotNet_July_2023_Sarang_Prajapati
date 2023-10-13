using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Two_Num_Disp_Greater_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter Number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2=Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("Number 1 is Greater");
            }
            else
            {
                Console.WriteLine("Number 2 is Greater");
            }
            Console.ReadKey();
        }
    }
}
