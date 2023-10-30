using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_ForEach_Loop_Print_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6 };

            int sum = 0;

            foreach(int val in arr)
            {
                sum = sum + val;
            }
            Console.WriteLine("Sum = "+sum);
            Console.ReadKey();
        }
    }
}
