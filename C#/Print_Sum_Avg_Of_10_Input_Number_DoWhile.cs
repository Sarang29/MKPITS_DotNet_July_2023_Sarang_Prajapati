using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Sum_Avg_Of_10_Input_Number_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int total = 0;
            float avg = 0;

            do
            {
                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());
                total = total + counter;
                avg=total / 10.0f;
                counter++;
            }
            while (counter <= 10);
            Console.WriteLine("Total = {0}", total);
            Console.WriteLine("Average = {0}", avg);
            Console.ReadKey();
        }
    }
}
