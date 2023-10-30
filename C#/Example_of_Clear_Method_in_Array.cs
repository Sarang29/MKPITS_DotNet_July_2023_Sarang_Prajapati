using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_of_Clear_Method_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 7, 8, 9, 4, 2, 5 };
            Array.Clear(arr, 0, 5);

            for(int i=0; i < arr.Length; i++)
            {
                Console.WriteLine("Clear Elements : "+arr[i]);
            }
            Console.ReadKey();
        }
    }
}
