using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disp_Day_from_Integer_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;

            Console.WriteLine("Enter Number");
            day=Convert.ToInt32(Console.ReadLine());

            if(day == 1)
            {
                Console.WriteLine("It Is Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("It Is Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("It Is Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("It Is Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("It Is Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("It Is Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("It Is Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();
        }
    }
}
