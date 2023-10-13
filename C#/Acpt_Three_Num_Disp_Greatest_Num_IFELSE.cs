using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acpt_Three_Num_Disp_Greatest_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number 1 is Greatest");
            }
            else if(num2 > num1 &&  num2 > num3)
            {
                Console.WriteLine("Number 2 is Greatest");
            }
            else
            {
                Console.WriteLine("Number 3 is Greatest");
            }
            Console.ReadKey();
        }
    }
}
