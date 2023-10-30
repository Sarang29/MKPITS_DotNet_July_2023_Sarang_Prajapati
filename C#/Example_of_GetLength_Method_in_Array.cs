using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_GetLength_Method_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            int res = arr.GetLength(0);
            Console.WriteLine("Length = " + res);

            Console.ReadKey();
        }
    }
}
