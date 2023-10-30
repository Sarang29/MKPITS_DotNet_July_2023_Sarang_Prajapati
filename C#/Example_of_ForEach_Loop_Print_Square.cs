using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_ForEach_Loop_Print_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5};

            int square = 0;

            foreach(int val in arr)
            {
                square = val * val;
            }
            Console.WriteLine("Square = "+square);
            Console.ReadKey();
        }
    }
}
