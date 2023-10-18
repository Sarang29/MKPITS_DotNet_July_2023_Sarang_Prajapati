using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disp_Sum_of_Odd_Natural_Number_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int num;
            int sum = 0;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine("{0} is Odd Number", counter);
                    sum = sum + counter;
                }
                counter++;

            } while (counter <= num);
            Console.WriteLine("Sum = {0}", sum);

            Console.ReadKey();
        }
    }
}
