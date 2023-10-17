using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_fibonnaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 1;
            int add = num1 + num2;
            int i = 3;
            Console.Write("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0},{1},", num1, num2);
            while (i <= num)
            {
                Console.Write("{0}, ", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                i++;
            }

            Console.ReadKey();

        }
    }
}