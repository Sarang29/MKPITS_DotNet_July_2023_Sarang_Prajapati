using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Sort_Method_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 6, 7, 3, 8, 4, 5 };
            Array.Sort(arr);

            for(int i=0; i < arr.Length; i++)
            {
                Console.WriteLine("Sorted Elements are : " + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
