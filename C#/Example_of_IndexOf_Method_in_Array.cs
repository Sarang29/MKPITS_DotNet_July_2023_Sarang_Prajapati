using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_IndexOf_Method_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            int res = Array.IndexOf(arr,6);

            Console.WriteLine("Index of 6 = "+res);

            Console.ReadKey();
        }
    }
}
