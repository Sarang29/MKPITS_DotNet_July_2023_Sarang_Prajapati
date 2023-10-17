using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_multiplicationtable_vertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 1, counter = 1;

            Console.Write("Input upto the table number starting from 1 : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (counter <= 10)
            {
                while (num1 <= num)
                {

                    Console.Write("{0}x{1} = {2}, ", num1, counter, counter * num1);

                    num1++;

                }
                Console.WriteLine();
                num1 = 1;
                counter++;
            }

            Console.ReadKey();
        }
    }
}